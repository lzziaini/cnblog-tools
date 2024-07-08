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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip1 = new MenuStrip();
            配置ToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem = new ToolStripMenuItem();
            sourceCode = new ToolStripMenuItem();
            about = new ToolStripMenuItem();
            ucPicProcess1 = new UcPicProcess();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            // ucPicProcess1
            // 
            ucPicProcess1.Location = new Point(0, 25);
            ucPicProcess1.Margin = new Padding(2, 3, 2, 3);
            ucPicProcess1.Name = "ucPicProcess1";
            ucPicProcess1.Size = new Size(908, 593);
            ucPicProcess1.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 618);
            Controls.Add(ucPicProcess1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CnblogTool";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
		private ToolStripMenuItem 配置ToolStripMenuItem;
		private ToolStripMenuItem ToolStripMenuItem;
		private ToolStripMenuItem about;
		private ToolStripMenuItem sourceCode;
        private UcPicProcess ucPicProcess1;
    }
}