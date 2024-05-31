namespace Cnblog.Tools
{
	partial class FormAbout
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
			blogid = new Label();
			linkLabel1 = new LinkLabel();
			label1 = new Label();
			label2 = new Label();
			linkLabel2 = new LinkLabel();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			label3 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// blogid
			// 
			blogid.AutoSize = true;
			blogid.Location = new Point(177, 283);
			blogid.Margin = new Padding(2, 0, 2, 0);
			blogid.Name = "blogid";
			blogid.Size = new Size(277, 17);
			blogid.TabIndex = 10;
			blogid.Text = "作者微信号~(如果有什么事微信号也可以联系作者)";
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(93, 11);
			linkLabel1.Margin = new Padding(2, 0, 2, 0);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(230, 17);
			linkLabel1.TabIndex = 9;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "https://www.cnblogs.com/q787011187";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(11, 11);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(80, 17);
			label1.TabIndex = 11;
			label1.Text = "作者博客园：";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(11, 37);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(82, 17);
			label2.TabIndex = 13;
			label2.Text = "作者Github：";
			// 
			// linkLabel2
			// 
			linkLabel2.AutoSize = true;
			linkLabel2.Location = new Point(93, 37);
			linkLabel2.Margin = new Padding(2, 0, 2, 0);
			linkLabel2.Name = "linkLabel2";
			linkLabel2.Size = new Size(158, 17);
			linkLabel2.TabIndex = 12;
			linkLabel2.TabStop = true;
			linkLabel2.Text = "https://github.com/lzziaini\r\n";
			linkLabel2.LinkClicked += linkLabel2_LinkClicked;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.微信二维码;
			pictureBox1.Location = new Point(240, 68);
			pictureBox1.Margin = new Padding(2, 3, 2, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(187, 204);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 14;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.微信赞赏码;
			pictureBox2.Location = new Point(86, 322);
			pictureBox2.Margin = new Padding(2, 3, 2, 3);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(233, 255);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 15;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.支付宝收款码;
			pictureBox3.Location = new Point(331, 322);
			pictureBox3.Margin = new Padding(2, 3, 2, 3);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(233, 255);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 16;
			pictureBox3.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(289, 598);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(77, 17);
			label3.TabIndex = 17;
			label3.Text = "好用，打赏~";
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(621, 626);
			Controls.Add(label3);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(label2);
			Controls.Add(linkLabel2);
			Controls.Add(label1);
			Controls.Add(blogid);
			Controls.Add(linkLabel1);
			Margin = new Padding(2, 3, 2, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form3";
			StartPosition = FormStartPosition.CenterParent;
			Text = "关于";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label blogid;
		private LinkLabel linkLabel1;
		private Label label1;
		private Label label2;
		private LinkLabel linkLabel2;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private Label label3;
	}
}