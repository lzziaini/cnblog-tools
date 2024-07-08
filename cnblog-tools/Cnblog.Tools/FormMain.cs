using CnBlogPublishTool;
using CnBlogPublishTool.Processor;
using CnBlogPublishTool.Util;
using MetaWeblogClient;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.IO;
using System.Xml.Linq;

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
            // 以下注释掉的代码用于测试发布和编辑博客的功能
            //ImageUploader.Init(Const.CnblogSettingPath, Const.TeaKey);
            //var postId = ImageUploader.BlogClient.NewPost("测试发布", "测试发布", new List<string> { "[Markdown]" }, false, DateTime.Now);
            //Process.Start(new ProcessStartInfo($"https://www.cnblogs.com/ChildishChange/p/{postId}.html") { UseShellExecute = true });

            //var editResult = ImageUploader.BlogClient.EditPost("16216527", "测试发布", "测试描述222222222222222222222222222222222222222222222<br>sdsdf", new List<string> { "[Markdown]" }, false);
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

    }
}