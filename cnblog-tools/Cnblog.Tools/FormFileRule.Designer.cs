namespace Cnblog.Tools
{
    partial class FormFileRule
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
            lstOriginalFiles = new ListBox();
            txtNewExpression = new TextBox();
            btnRename = new Button();
            lstPreView = new ListBox();
            btnTest = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbx_defaultExample = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // lstOriginalFiles
            // 
            lstOriginalFiles.FormattingEnabled = true;
            lstOriginalFiles.ItemHeight = 17;
            lstOriginalFiles.Location = new Point(13, 32);
            lstOriginalFiles.Margin = new Padding(4);
            lstOriginalFiles.Name = "lstOriginalFiles";
            lstOriginalFiles.Size = new Size(520, 140);
            lstOriginalFiles.TabIndex = 0;
            // 
            // txtNewExpression
            // 
            txtNewExpression.Location = new Point(125, 211);
            txtNewExpression.Margin = new Padding(4);
            txtNewExpression.Name = "txtNewExpression";
            txtNewExpression.Size = new Size(359, 23);
            txtNewExpression.TabIndex = 1;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(446, 433);
            btnRename.Margin = new Padding(4);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(88, 30);
            btnRename.TabIndex = 4;
            btnRename.Text = "确认";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnEnsure_Click;
            // 
            // lstPreView
            // 
            lstPreView.FormattingEnabled = true;
            lstPreView.ItemHeight = 17;
            lstPreView.Location = new Point(12, 285);
            lstPreView.Margin = new Padding(4);
            lstPreView.Name = "lstPreView";
            lstPreView.Size = new Size(520, 140);
            lstPreView.TabIndex = 0;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(492, 207);
            btnTest.Margin = new Padding(4);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(41, 30);
            btnTest.TabIndex = 4;
            btnTest.Text = "测试";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnRename_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 264);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 5;
            label1.Text = "新文件名预览：";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 214);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 5;
            label2.Text = "新文件名表达式：";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 180);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(359, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "$filename$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 183);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 5;
            label3.Text = "原文件名表达式：";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 11);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 5;
            label4.Text = "原始文件名：";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbx_defaultExample
            // 
            tbx_defaultExample.Location = new Point(125, 240);
            tbx_defaultExample.Margin = new Padding(4);
            tbx_defaultExample.Name = "tbx_defaultExample";
            tbx_defaultExample.ReadOnly = true;
            tbx_defaultExample.Size = new Size(359, 23);
            tbx_defaultExample.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 243);
            label5.Name = "label5";
            label5.Size = new Size(104, 17);
            label5.TabIndex = 5;
            label5.Text = "一个默认的案例：";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormFileRule
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 471);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTest);
            Controls.Add(btnRename);
            Controls.Add(textBox1);
            Controls.Add(tbx_defaultExample);
            Controls.Add(txtNewExpression);
            Controls.Add(lstPreView);
            Controls.Add(lstOriginalFiles);
            Margin = new Padding(4);
            Name = "FormFileRule";
            Text = "File Renaming App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstOriginalFiles;
        private System.Windows.Forms.TextBox txtNewExpression;
        private System.Windows.Forms.Button btnRename;
        private ListBox lstPreView;
        private Button btnTest;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox tbx_defaultExample;
        private Label label5;
    }
}