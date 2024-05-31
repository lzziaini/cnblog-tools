namespace Cnblog.Tools
{
	partial class FormCnblogSetting
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			textUserName = new TextBox();
			textPassword = new TextBox();
			label2 = new Label();
			btnComfirm = new Button();
			textBlogid = new TextBox();
			label3 = new Label();
			linkLabel1 = new LinkLabel();
			blogid = new Label();
			linkLabel2 = new LinkLabel();
			label4 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(11, 78);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(52, 17);
			label1.TabIndex = 0;
			label1.Text = "账  号：";
			// 
			// textUserName
			// 
			textUserName.Location = new Point(68, 76);
			textUserName.Margin = new Padding(2, 3, 2, 3);
			textUserName.Name = "textUserName";
			textUserName.Size = new Size(266, 23);
			textUserName.TabIndex = 7;
			// 
			// textPassword
			// 
			textPassword.Location = new Point(68, 105);
			textPassword.Margin = new Padding(2, 3, 2, 3);
			textPassword.Name = "textPassword";
			textPassword.Size = new Size(266, 23);
			textPassword.TabIndex = 8;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(11, 107);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(68, 17);
			label2.TabIndex = 2;
			label2.Text = "访问令牌：";
			// 
			// btnComfirm
			// 
			btnComfirm.Location = new Point(11, 167);
			btnComfirm.Margin = new Padding(2, 3, 2, 3);
			btnComfirm.Name = "btnComfirm";
			btnComfirm.Size = new Size(323, 25);
			btnComfirm.TabIndex = 9;
			btnComfirm.Text = "确认";
			btnComfirm.UseVisualStyleBackColor = true;
			btnComfirm.Click += btnComfirm_Click;
			// 
			// textBlogid
			// 
			textBlogid.Location = new Point(68, 46);
			textBlogid.Margin = new Padding(2, 3, 2, 3);
			textBlogid.Name = "textBlogid";
			textBlogid.Size = new Size(266, 23);
			textBlogid.TabIndex = 6;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(11, 48);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(48, 17);
			label3.TabIndex = 5;
			label3.Text = "博客ID:";
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(9, 8);
			linkLabel1.Margin = new Padding(2, 0, 2, 0);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(230, 17);
			linkLabel1.TabIndex = 17;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "https://www.cnblogs.com/q787011187";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// blogid
			// 
			blogid.AutoSize = true;
			blogid.Location = new Point(9, 26);
			blogid.Margin = new Padding(2, 0, 2, 0);
			blogid.Name = "blogid";
			blogid.Size = new Size(361, 17);
			blogid.TabIndex = 18;
			blogid.Text = "博客ID每个账号唯一如上是我的博客园地址，ID为：q787011187 ";
			// 
			// linkLabel2
			// 
			linkLabel2.AutoSize = true;
			linkLabel2.Location = new Point(11, 130);
			linkLabel2.Margin = new Padding(2, 0, 2, 0);
			linkLabel2.Name = "linkLabel2";
			linkLabel2.Size = new Size(307, 17);
			linkLabel2.TabIndex = 19;
			linkLabel2.TabStop = true;
			linkLabel2.Text = "https://i.cnblogs.com/settings#enableServiceAccess";
			linkLabel2.LinkClicked += linkLabel2_LinkClicked;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(9, 147);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(357, 17);
			label4.TabIndex = 20;
			label4.Text = "点击链接到底部其他设置->“Metaweblog访问令牌”->\"查看\"获取";
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(369, 201);
			Controls.Add(label4);
			Controls.Add(linkLabel2);
			Controls.Add(blogid);
			Controls.Add(linkLabel1);
			Controls.Add(textBlogid);
			Controls.Add(label3);
			Controls.Add(btnComfirm);
			Controls.Add(textPassword);
			Controls.Add(label2);
			Controls.Add(textUserName);
			Controls.Add(label1);
			Margin = new Padding(2, 3, 2, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form2";
			StartPosition = FormStartPosition.CenterParent;
			Text = "配置您的博客园账号";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textUserName;
		private TextBox textPassword;
		private Label label2;
		private Button btnComfirm;
		private TextBox textBlogid;
		private Label label3;
		private LinkLabel linkLabel1;
		private Label blogid;
		private LinkLabel linkLabel2;
		private Label label4;
	}
}