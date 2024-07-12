using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cnblog.Tools
{
    public partial class UcToolsList : UserControl
    {
        private Panel toolsPanel;//具体工具面板
        private FlowLayoutPanel toolCollectionPanel;//工具集合面板
        private Dictionary<string, UserControl> toolControls; // 存储工具控件的字典
        private UserControl currentTool; // 当前显示的工具控件
        Button backButton; //返回按钮
        Label toolLabel;//工具名称标签
        TableLayoutPanel toolHeaderPanel;//包含工具名称和返回按钮的 TableLayoutPanel
        public UcToolsList()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.DoubleBuffered = true;
            this.Load += new EventHandler(Uc_Loaded);
        }

        private void Uc_Loaded(object? sender, EventArgs e)
        {
            InitializeTools();
            InitializeToolCollection();
        }

        private void InitializeToolCollection()
        {
            // 隐藏主面板来减少闪烁
            this.SuspendLayout();


            // 创建工具集合面板
            toolCollectionPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            this.Controls.Add(toolCollectionPanel);

            // 预先创建所有工具控件实例
            AddTool("图片/文件处理工具", Properties.Resources.微信二维码, new UcPicProcess());

            // 创建返回按钮
            backButton = new Button
            {
                Text = "<--",
                Dock = DockStyle.Fill,
            };
            backButton.Click += backButton_Click;
            // 创建和添加工具名称标签
            toolLabel = new Label
            {
                Text = "",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // 创建包含工具名称和返回按钮的 TableLayoutPanel
            toolHeaderPanel = new TableLayoutPanel
            {
                RowCount = 1,
                ColumnCount = 3,
                Dock = DockStyle.Top,
                Height = 30
            };
            toolHeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            toolHeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            toolHeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            toolHeaderPanel.Controls.Add(backButton, 0, 0);//返回按钮
            toolHeaderPanel.Controls.Add(toolLabel, 1, 0);//工具名称标签
            toolHeaderPanel.Controls.Add(new Label(), 2, 0);// 添加右侧空白占位符

            // 创建工具面板，并添加到主窗体
            toolsPanel = new Panel
            {
                Dock = DockStyle.Fill,
                //Visible = false
            };
            toolsPanel.Controls.Add(toolHeaderPanel);
            foreach (var toolControl in toolControls)
            {
                //toolControl.Value.Visible = false;
                toolControl.Value.Visible = true;
                toolsPanel.Controls.Add(toolControl.Value);
            }
            this.Controls.Add(toolsPanel);
            toolsPanel.BringToFront();

            //将工具面板置为初始不可见
            foreach (var toolControl in toolControls)
            {
                toolControl.Value.Visible = false;
            }
            toolsPanel.Visible = false;

            // 恢复主面板的显示
            this.ResumeLayout(true);
        }
         
        private void InitializeTools()
        {
            toolControls = new Dictionary<string, UserControl>();
        }

        private void AddTool(string toolName, Image toolImage, UserControl userControl)
        {
            if (toolControls == null)
                toolControls = new Dictionary<string, UserControl>();

            toolControls.Add(toolName, userControl);
            AddToolButton(toolName, toolImage);
        }
        private void AddToolButton(string toolName, Image toolImage)
        {
            // 创建表示工具的按钮
            Button toolButton = new Button
            {
                Width = 100,
                Height = 100,
                Image = toolImage,
                Text = toolName,
                TextAlign = ContentAlignment.BottomCenter,
                ImageAlign = ContentAlignment.TopCenter
            };
            toolButton.Click += (sender, e) => OpenTool(toolName);
            toolCollectionPanel.Controls.Add(toolButton);
        }
        private void OpenTool(string toolName)
        {
            // 隐藏主面板来减少闪烁
            toolsPanel.SuspendLayout();

            // 更新 toolHeaderPanel 的标题，如果有的话
            UpdateToolHeader(toolName);

            // 隐藏所有的工具控件
            //foreach (var toolControl in toolControls)
            //{
            //    toolControl.Value.Visible = false ;
            //}

            if(currentTool != null)
            {
                currentTool.Visible = false;
            }
            // 显示所选的工具控件
            currentTool = toolControls[toolName];
            currentTool.Dock = DockStyle.Fill;
            currentTool.Visible = true;
            currentTool.BringToFront(); // 确保所选工具控件在最前面

            toolsPanel.Visible = true; // 显示工具页面
            toolCollectionPanel.Visible = false; // 隐藏工具集页面

            // 恢复主面板的显示
            toolsPanel.ResumeLayout(true);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // 处理后退按钮的点击事件
            toolsPanel.Visible = false; // 隐藏工具页面
            toolCollectionPanel.Visible = true; // 显示工具集页面
        }
        private void UpdateToolHeader(string toolName)
        {
            // 假设 toolHeaderPanel 是一个包含标题的 Label 控件
            // 更新标题
            toolLabel.Text = toolName; // toolLabel 是 toolHeaderPanel 中的一个 Label 控件
        }

    }
}
