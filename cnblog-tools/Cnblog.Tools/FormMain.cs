using CnBlogPublishTool;
using CnBlogPublishTool.Processor;
using CnBlogPublishTool.Util;
using MetaWeblogClient;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.IO;

namespace Cnblog.Tools
{
	public partial class FormMain : Form
	{
		/// <summary>
		/// ReplaceDic 用于存储替换图片链接时的映射关系
		/// </summary>
		private static readonly Dictionary<string, string> ReplaceDic = new Dictionary<string, string>();

		public FormMain()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// 设置控制台文本背景颜色
			this.textConsole.BackColor = Color.FromArgb(41, 49, 52);

			// 如果配置文件存在，加载配置文件并初始化最近目录列表
			if (File.Exists(Const.Appsettings))
			{
				// 从配置文件中反序列化配置信息
				var config = JsonConvert.DeserializeObject<Appsettings>(File.ReadAllText(Const.Appsettings));
				// 如果配置中有最近使用的目录列表
				if (config.RecentDir?.Dirs?.Count > 0 == true)
				{
					// 初始化树形节点，显示最后一个使用的目录
					initTreeNode(config.RecentDir.Dirs.Last());
					// 将目录列表反转
					config.RecentDir.Dirs.Reverse();
					// 将目录列表添加到下拉框中
					this.comboxPath.Items.AddRange(config.RecentDir.Dirs.ToArray());
				}
			}

			// 以下注释掉的代码用于测试发布和编辑博客的功能
			//ImageUploader.Init(Const.CnblogSettingPath, Const.TeaKey);
			//var postId = ImageUploader.BlogClient.NewPost("测试发布", "测试发布", new List<string> { "[Markdown]" }, false, DateTime.Now);
			//Process.Start(new ProcessStartInfo($"https://www.cnblogs.com/ChildishChange/p/{postId}.html") { UseShellExecute = true });

			//var editResult = ImageUploader.BlogClient.EditPost("16216527", "测试发布", "测试描述222222222222222222222222222222222222222222222<br>sdsdf", new List<string> { "[Markdown]" }, false);
		}

		/// <summary>
		/// 设置最近目录的方法，用于更新配置文件中的目录记录
		/// </summary>
		/// <param name="path"></param>
		private void setRecentDirs(string path)
		{
			// 如果配置文件存在
			if (File.Exists(Const.Appsettings))
			{
				// 从配置文件中反序列化配置信息
				var config = JsonConvert.DeserializeObject<Appsettings>(File.ReadAllText(Const.Appsettings));
				// 如果已经达到最大记录数
				if (config.RecentDir?.Dirs?.Count >= config.RecentDir.MaxRecond)
				{
					// 替换最后一个记录为当前路径
					config.RecentDir.Dirs[config.RecentDir.MaxRecond - 1] = path;
				}
				else
				{
					// 如果路径已存在于记录中，先移除
					if (config?.RecentDir?.Dirs?.Contains(path) == true)
					{
						config.RecentDir?.Dirs.Remove(path);
					}
					// 添加路径到列表
					config.RecentDir?.Dirs.Add(path);
				}
				// 将更新后的配置信息序列化并写回配置文件
				File.WriteAllText(Const.Appsettings, JsonConvert.SerializeObject(config));
			}
		}

		/// <summary>
		/// “选择文件夹”按钮点击事件处理程序
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSelectFold_Click(object sender, EventArgs e)
		{
			// 创建文件夹浏览对话框
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			// 设置对话框描述
			folderBrowserDialog.Description = "请选择博客md文件目录";
			// 设置初始路径为应用程序启动路径
			folderBrowserDialog.SelectedPath = Application.StartupPath;
			// 允许用户创建新文件夹
			folderBrowserDialog.ShowNewFolderButton = true;
			// 如果用户选择了文件夹并确认
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				// 初始化树形节点，将选择的文件夹路径显示在树形视图中
				initTreeNode(folderBrowserDialog.SelectedPath);
			}
		}

		/// <summary>
		/// 初始化树形节点的方法，用于显示文件和目录结构
		/// </summary>
		/// <param name="path"></param>
		private void initTreeNode(string path)
		{
			// 设置下拉框文本为当前路径
			comboxPath.Text = path;
			// 清除树形视图的所有节点
			treeViewFolder.Nodes.Clear();
			// 创建一个新的树节点作为根节点
			TreeNode rootNode = new TreeNode();
			// 展开根节点
			rootNode.ExpandAll();

			// 调用initTreeNode方法，初始化树形节点
			initTreeNode(comboxPath.Text, rootNode);
			// 将根节点添加到树形视图中
			treeViewFolder.Nodes.Add(rootNode);
			// 更新最近目录列表
			setRecentDirs(path);
		}

		/// <summary>
		/// 重载的initTreeNode方法，用于递归添加目录和文件到树形视图
		/// </summary>
		/// <param name="folderPath"></param>
		/// <param name="parentNode"></param>
		private void initTreeNode(string folderPath, TreeNode parentNode)
		{
			// 设置父节点的文本为文件夹名称
			parentNode.Text = Path.GetFileNameWithoutExtension(folderPath);
			DirectoryInfo tempDir = null;
			TreeNode subNode = null;

			//递归遍历文件夹和文件，并添加到树节点中

			//读取文件夹下的目录
			string[] dics = Directory.GetDirectories(folderPath);
			foreach (string dic in dics)
			{
				tempDir = new DirectoryInfo(dic);
				subNode = new TreeNode(tempDir.Name); //实例化
				subNode.Name = new DirectoryInfo(dic).Name; //.FullName//完整目录
				subNode.Tag = subNode.Name;
				subNode.ImageIndex = Icons.Floder;       //获取节点显示图片
				subNode.SelectedImageIndex = Icons.Selected; //选择节点显示图片
															 //subNode.Nodes.Add("");   //加载空节点 实现+号

				parentNode.Nodes.Add(subNode);

				//TODO 递归读取所有子目录,这里我就不递归读了
				//initTreeNode(tempDir.FullName, subNode);
			}

			//读取文件夹下的文件
			TreeNode fileNode = null;
			string[] tempFiles = Directory.GetFiles(folderPath);

			var orderFiles = tempFiles.OrderByDescending(ss => new FileInfo(ss).LastWriteTime).ToArray();
			foreach (string fileFullName in orderFiles)
			{
				fileNode = new TreeNode(fileFullName);
				fileNode.Name = fileFullName;
				fileNode.Text = Path.GetFileName(fileFullName);
				fileNode.SelectedImageIndex = Icons.Selected; //选择节点显示图片

				if (fileFullName.Contains(".md", StringComparison.OrdinalIgnoreCase))
				{
					fileNode.ImageIndex = Icons.Markdown;
				}
				else
				{
					fileNode.ImageIndex = Icons.File;
				}
				parentNode.Nodes.Add(fileNode);
			}
		}

		/// <summary>
		/// 路径选择下拉框选项变更时触发的事件处理程序
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboxPath_SelectedIndexChanged(object sender, EventArgs e)
		{
			// 调用initTreeNode方法，根据下拉框选择的路径初始化树形节点
			initTreeNode(this.comboxPath.Text);
		}

		/// <summary>
		/// 树形视图中的项拖动时触发的事件处理程序
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void treeViewFolder_ItemDrag(object sender, ItemDragEventArgs e)
		{
			// 创建一个数据对象，用于存储拖动的数据
			IDataObject data = new DataObject();
			// 将拖动的节点添加到数据对象中
			data.SetData("dragnode", e.Item);
			// 开始拖放操作
			this.DoDragDrop(data, DragDropEffects.Copy);
		}

		/// <summary>
		/// 拖动对象进入panel2控件边界时触发的事件处理程序
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void panel2_DragEnter(object sender, DragEventArgs e)
		{
			// 检查拖动的数据是否是从树形目录中拖拽来的节点
			var treeNode = e?.Data?.GetDataPresent("dragnode") != null;

			if (treeNode == false) // 如果不是从树形目录中拖拽来的
			{
				// 检查拖动的数据是否是文件
				if (e?.Data?.GetDataPresent(DataFormats.FileDrop) != null)
				{
					// 设置拖放效果为复制
					e.Effect = DragDropEffects.Copy;
				}
				else
				{
					// 否则不允许拖放
					e.Effect = DragDropEffects.None;
				}
			}
			else
			{
				// 如果拖动的数据是树形节点
				if (e?.Data?.GetDataPresent("dragnode") != null)
				{
					// 设置拖放效果为复制
					e.Effect = DragDropEffects.Copy;
				}
				else
				{
					// 否则不允许拖放
					e.Effect = DragDropEffects.None;
				}
			}
		}

		/// <summary>
		/// 加载博客账户设置的方法
		/// </summary>
		private void loadBlogAccount()
		{
			// 如果博客设置文件不存在
			if (File.Exists(Const.CnblogSettingPath) == false)
			{
				// 弹出博客设置对话框
				new FormCnblogSetting().ShowDialog();
				return;
			}
			else
			{
				// 如果文件存在，初始化图片上传器
				ImageUploader.Init(Const.CnblogSettingPath, Const.TeaKey);
			}
		}

		/// <summary>
		/// 拖放操作完成时触发的事件处理程序
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void panel2_DragDrop(object sender, DragEventArgs e)
		{
			// 尝试执行拖放操作
			try
			{
				// 确保博客设置文件存在，否则弹出设置对话框
				if (File.Exists(Const.CnblogSettingPath) == false)
				{
					new FormCnblogSetting().ShowDialog();
					return;
				}
				else
				{
					// 初始化图片上传器
					ImageUploader.Init(Const.CnblogSettingPath, Const.TeaKey);
				}

				// 获取拖动的节点对象
				object? nodeItem = e?.Data?.GetData("dragnode");

				// 如果是树形视图中的节点
				if (nodeItem != null)
				{
					// 转换为树节点
					TreeNode node = (TreeNode)nodeItem;
					// 在控制台输出处理文件信息
					echo($"正在处理文件：{node.Name}");
					// 处理文件（上传图片并替换Markdown中的图片链接）
					processFile(node.Name);
				}
				else
				{
					// 如果是外部文件拖放
					// 获取拖放的文件路径
					string dropFilePath = ((Array)e.Data?.GetData(DataFormats.FileDrop))?.GetValue(0)?.ToString();
					// 获取文件扩展名
					var extension = Path.GetExtension(dropFilePath);
					// 如果是Markdown文件
					if (extension.Contains(".md", StringComparison.OrdinalIgnoreCase))
					{
						// 处理Markdown文件
						processFile(dropFilePath);
					}
					else if (Const.SupportImageType.Contains(extension, StringComparison.OrdinalIgnoreCase))
					{
						// 如果是支持的图片类型，上传图片
						var imgUrl = ImageUploader.Upload(dropFilePath);
						// 在控制台输出上传成功的信息
						echo($"图片{dropFilePath} 上传成功 \r\n {imgUrl}\r\n![{Path.GetFileName(dropFilePath)}]({imgUrl})");
					}
					else
					{
						// 如果文件类型不支持，弹出提示框
						MessageBox.Show("暂只支持上传markdown文件和图片！");
					}
				}
			}
			catch (Exception ex)
			{
				// 如果过程中出现异常，输出异常信息到控制台
				echo(ex.Message + ex.StackTrace);
			}
		}

		/// <summary>
		/// 处理文件的方法，用于上传图片并替换Markdown中的图片链接
		/// </summary>
		/// <param name="filePath"></param>
		private void processFile(string filePath)
		{
			// 读取Markdown文件内容
			// 提取图片链接
			// 上传图片到博客平台
			// 替换Markdown文件中的本地图片链接为远程URL
			// 保存处理后的文件
			// 如果过程中出现异常，会捕获并输出到控制台。

			try
			{
				if (!File.Exists(filePath))
				{
					echo("指定的文件不存在！");
				}
				else
				{
					var uploadSuccess = 0;
					var _fileDir = new FileInfo(filePath).DirectoryName;
					var _fileContent = File.ReadAllText(filePath);
					var imgProcessor = new ImageProcessor();
					var imgList = imgProcessor.Process(_fileContent);
					echo($"提取图片成功，共{imgList.Count}个");

					//循环上传图片
					foreach (var img in imgList)
					{
						if (img.StartsWith("http", StringComparison.OrdinalIgnoreCase))
						{
							echo($"图片跳过：{img} ");
							continue;
						}

						try
						{
							string imgPhyPath = Path.Combine(_fileDir, img);//可能是相对路径，跟md文件路径组合为绝对路径
							if (File.Exists(imgPhyPath))
							{
								var imgUrl = ImageUploader.Upload(imgPhyPath);
								echo($"{img} 上传成功+{++uploadSuccess}. {imgUrl}");
								if (!ReplaceDic.ContainsKey(img))
								{
									ReplaceDic.Add(img, imgUrl);
								}
							}
							else
							{
								echo($"{img} 未发现文件");
							}
						}
						catch (Exception e)
						{
							echo(e.Message + e.StackTrace);
						}
					}

					//替换图片链接
					foreach (var key in ReplaceDic.Keys)
					{
						_fileContent = _fileContent.Replace(key, ReplaceDic[key]);
					}

					//var newFileName = filePath.Substring(0, filePath.LastIndexOf('.')) + "-cnblog" + Path.GetExtension(filePath);
					var newFileName = filePath;///TODO 此处后续拓展存图规则
					File.WriteAllText(newFileName, _fileContent, EncodingType.GetType(filePath));

					echo($"共提取图片{imgList.Count}，上传成功{uploadSuccess}张，处理完成!");
					echo($"处理后文件保存在：{newFileName}");
				}
			}
			catch (Exception e)
			{
				echo(e.Message + e.StackTrace);
			}
		}

		/// <summary>
		/// 在控制台输出内容的方法，输出一行到控制台
		/// </summary>
		/// <param name="content"></param>
		private void echo(string content)
		{
			// 将传入的内容追加到文本框中，每条内容后面追加换行符
			this.textConsole.Text += $"{content}\r\n";
		}

		/// <summary>
		/// panel2绘制时触发的事件处理程序，用于自定义边框样式
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			// 获取触发事件的Panel对象
			Panel pan = (Panel)sender;
			// 设置画笔宽度
			float width = (float)4.0;
			// 创建画笔对象，设置颜色和宽度
			Pen pen = new Pen(SystemColors.ControlDark, width);
			// 设置画笔样式为点线
			pen.DashStyle = DashStyle.Dot;
			// 绘制Panel的边框
			e.Graphics.DrawLine(pen, 0, 0, 0, pan.Height - 0);
			e.Graphics.DrawLine(pen, 0, 0, pan.Width - 0, 0);
			e.Graphics.DrawLine(pen, pan.Width - 1, pan.Height - 1, 0, pan.Height - 1);
			e.Graphics.DrawLine(pen, pan.Width - 1, pan.Height - 1, pan.Width - 1, 0);
		}

		/// <summary>
		/// “设置”菜单项点击时触发的事件处理程序
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FormCnblogSetting().ShowDialog();
		}

		/// <summary>
		/// “关于”菜单项点击时触发的事件处理程序
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void about_Click(object sender, EventArgs e)
		{
			new FormAbout().ShowDialog();
		}

		/// <summary>
		/// “源代码”菜单项点击时触发的事件处理程序，打开GitHub源代码页面
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void sourceCode_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo("https://github.com/lzziaini/cnblog-tools") { UseShellExecute = true });
		}

		/// <summary>
		/// 树形视图鼠标按下时触发的事件处理程序，用于显示上下文菜单
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void treeViewFolder_MouseDown(object sender, MouseEventArgs e)
		{
			// 如果是右键点击
			if (e.Button == MouseButtons.Right)
			{
				// 获取鼠标点击的位置
				Point ClickPoint = new Point(e.X, e.Y);
				// 获取点击位置的节点
				TreeNode currentNode = treeViewFolder.GetNodeAt(ClickPoint);
				// 如果点击的是节点
				if (currentNode != null)
				{
					// 设置当前节点为选中状态
					treeViewFolder.SelectedNode = currentNode;
					// 显示节点的上下文菜单
					treeViewFolder.SelectedNode.ContextMenuStrip = contextMenuStrip1;
				}
			}
		}

		/// <summary>
		/// “新建草稿”菜单项点击时触发的事件处理程序，用于快速编辑并发布Markdown文件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemNewDraft_Click(object sender, EventArgs e)
		{
			// 检查博客设置文件，如果设置文件不存在则弹出设置对话框。
			// 如果文件存在，则处理选中的Markdown文件，上传图片并替换链接，
			// 最后调用博客平台的API发布文章，并在默认浏览器中打开编辑页面。
			// 如果过程中出现异常，会捕获并输出到控制台。
			if (treeViewFolder.SelectedNode != null)
			{
				if (File.Exists(Const.CnblogSettingPath) == false)
				{
					new FormCnblogSetting().ShowDialog();
					return;
				}
				else
				{
					ImageUploader.Init(Const.CnblogSettingPath, Const.TeaKey);
				}
				var fileFullName = treeViewFolder.SelectedNode.Name;
				if (fileFullName.Contains(".md", StringComparison.OrdinalIgnoreCase))
				{
					try
					{
						processFile(fileFullName);
						var title = Path.GetFileNameWithoutExtension(fileFullName);
						var content = File.ReadAllText(treeViewFolder.SelectedNode.Name);
						var postId = ImageUploader.BlogClient.NewPost(title, content, new List<string> { "[Markdown]" }, false, DateTime.Now);
						echo($"快速编辑文章成功：{$"https://www.cnblogs.com/{ImageUploader.BlogClient.BlogConnectionInfo.BlogID}/p/{postId}.html"}");
						Process.Start(new ProcessStartInfo($"https://i.cnblogs.com/posts/edit;postId={postId}") { UseShellExecute = true });
					}
					catch (Exception ex)
					{
						echo(ex.Message);
					}
				}
				else
				{
					MessageBox.Show("暂只支持上传markdown文件(.md)快速编辑发布");
				}
			}
		}
	}
}