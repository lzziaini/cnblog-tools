namespace Cnblog.Tools
{
	partial class FormMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			panel1 = new Panel();
			btnSelectFold = new Button();
			comboxPath = new ComboBox();
			splitContainer1 = new SplitContainer();
			treeViewFolder = new TreeView();
			IconList = new ImageList(components);
			textConsole = new TextBox();
			panel2 = new Panel();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			menuStrip1 = new MenuStrip();
			配置ToolStripMenuItem = new ToolStripMenuItem();
			ToolStripMenuItem = new ToolStripMenuItem();
			sourceCode = new ToolStripMenuItem();
			about = new ToolStripMenuItem();
			contextMenuStrip1 = new ContextMenuStrip(components);
			menuItemNewDraft = new ToolStripMenuItem();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			menuStrip1.SuspendLayout();
			contextMenuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(btnSelectFold);
			panel1.Controls.Add(comboxPath);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 25);
			panel1.Margin = new Padding(2, 3, 2, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(908, 36);
			panel1.TabIndex = 0;
			// 
			// btnSelectFold
			// 
			btnSelectFold.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnSelectFold.Location = new Point(826, 6);
			btnSelectFold.Margin = new Padding(2, 3, 2, 3);
			btnSelectFold.Name = "btnSelectFold";
			btnSelectFold.Size = new Size(80, 25);
			btnSelectFold.TabIndex = 1;
			btnSelectFold.Text = "打开目录...";
			btnSelectFold.UseVisualStyleBackColor = true;
			btnSelectFold.Click += btnSelectFold_Click;
			// 
			// comboxPath
			// 
			comboxPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			comboxPath.FormattingEnabled = true;
			comboxPath.Location = new Point(3, 6);
			comboxPath.Margin = new Padding(2, 3, 2, 3);
			comboxPath.Name = "comboxPath";
			comboxPath.Size = new Size(821, 25);
			comboxPath.TabIndex = 0;
			comboxPath.SelectedIndexChanged += comboxPath_SelectedIndexChanged;
			// 
			// splitContainer1
			// 
			splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			splitContainer1.Cursor = Cursors.VSplit;
			splitContainer1.Location = new Point(3, 59);
			splitContainer1.Margin = new Padding(2, 3, 2, 3);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(treeViewFolder);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.AllowDrop = true;
			splitContainer1.Panel2.BackColor = Color.White;
			splitContainer1.Panel2.Controls.Add(textConsole);
			splitContainer1.Panel2.Controls.Add(panel2);
			splitContainer1.Size = new Size(903, 556);
			splitContainer1.SplitterDistance = 311;
			splitContainer1.SplitterWidth = 3;
			splitContainer1.TabIndex = 1;
			// 
			// treeViewFolder
			// 
			treeViewFolder.AllowDrop = true;
			treeViewFolder.Dock = DockStyle.Fill;
			treeViewFolder.ImageIndex = 0;
			treeViewFolder.ImageList = IconList;
			treeViewFolder.Location = new Point(0, 0);
			treeViewFolder.Margin = new Padding(2, 3, 2, 3);
			treeViewFolder.Name = "treeViewFolder";
			treeViewFolder.SelectedImageIndex = 0;
			treeViewFolder.Size = new Size(311, 556);
			treeViewFolder.TabIndex = 0;
			treeViewFolder.ItemDrag += treeViewFolder_ItemDrag;
			treeViewFolder.MouseDown += treeViewFolder_MouseDown;
			// 
			// IconList
			// 
			IconList.ColorDepth = ColorDepth.Depth8Bit;
			IconList.ImageStream = (ImageListStreamer)resources.GetObject("IconList.ImageStream");
			IconList.TransparentColor = Color.Transparent;
			IconList.Images.SetKeyName(0, "folder.png");
			IconList.Images.SetKeyName(1, "cfolder.png");
			IconList.Images.SetKeyName(2, "markdown.png");
			IconList.Images.SetKeyName(3, "file.png");
			// 
			// textConsole
			// 
			textConsole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textConsole.BackColor = Color.White;
			textConsole.ForeColor = Color.White;
			textConsole.Location = new Point(8, 133);
			textConsole.Margin = new Padding(2, 3, 2, 3);
			textConsole.Multiline = true;
			textConsole.Name = "textConsole";
			textConsole.ScrollBars = ScrollBars.Both;
			textConsole.Size = new Size(575, 417);
			textConsole.TabIndex = 1;
			textConsole.WordWrap = false;
			// 
			// panel2
			// 
			panel2.AllowDrop = true;
			panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			panel2.Controls.Add(label1);
			panel2.Controls.Add(pictureBox1);
			panel2.Location = new Point(8, 9);
			panel2.Margin = new Padding(2, 3, 2, 3);
			panel2.Name = "panel2";
			panel2.Size = new Size(574, 118);
			panel2.TabIndex = 0;
			panel2.DragDrop += panel2_DragDrop;
			panel2.DragEnter += panel2_DragEnter;
			panel2.Paint += panel2_Paint;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 14.04878F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(100, 90);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(426, 24);
			label1.TabIndex = 1;
			label1.Text = "从左侧拖拽或直接拖拽Markdown/图片文件到此处";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(243, 3);
			pictureBox1.Margin = new Padding(2, 3, 2, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(81, 85);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { 配置ToolStripMenuItem, sourceCode, about });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(5, 2, 0, 2);
			menuStrip1.Size = new Size(908, 25);
			menuStrip1.TabIndex = 2;
			menuStrip1.Text = "menuStrip1";
			// 
			// 配置ToolStripMenuItem
			// 
			配置ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem });
			配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
			配置ToolStripMenuItem.Size = new Size(58, 21);
			配置ToolStripMenuItem.Text = "设置(c)";
			// 
			// ToolStripMenuItem
			// 
			ToolStripMenuItem.Name = "ToolStripMenuItem";
			ToolStripMenuItem.Size = new Size(124, 22);
			ToolStripMenuItem.Text = "配置账号";
			ToolStripMenuItem.Click += ToolStripMenuItem_Click;
			// 
			// sourceCode
			// 
			sourceCode.Name = "sourceCode";
			sourceCode.Size = new Size(44, 21);
			sourceCode.Text = "源码";
			sourceCode.Click += sourceCode_Click;
			// 
			// about
			// 
			about.Name = "about";
			about.Size = new Size(44, 21);
			about.Text = "关于";
			about.Click += about_Click;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(20, 20);
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { menuItemNewDraft });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(173, 26);
			// 
			// menuItemNewDraft
			// 
			menuItemNewDraft.Name = "menuItemNewDraft";
			menuItemNewDraft.Size = new Size(172, 22);
			menuItemNewDraft.Text = "快速编辑发布此文";
			menuItemNewDraft.Click += menuItemNewDraft_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(908, 618);
			Controls.Add(splitContainer1);
			Controls.Add(panel1);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Margin = new Padding(2, 3, 2, 3);
			Name = "FormMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "CnblogTool";
			Load += Form1_Load;
			panel1.ResumeLayout(false);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			contextMenuStrip1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private SplitContainer splitContainer1;
		private Panel panel1;
		private Button btnSelectFold;
		private ComboBox comboxPath;
		private TreeView treeViewFolder;
		private ImageList IconList;
		private Panel panel2;
		private TextBox textConsole;
		private Label label1;
		private PictureBox pictureBox1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem 配置ToolStripMenuItem;
		private ToolStripMenuItem ToolStripMenuItem;
		private ToolStripMenuItem about;
		private ToolStripMenuItem sourceCode;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem menuItemNewDraft;
	}
}