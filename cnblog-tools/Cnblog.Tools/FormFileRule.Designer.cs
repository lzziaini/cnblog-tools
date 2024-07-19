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
            chkCaseSensitive = new CheckBox();
            chkUseRegex = new CheckBox();
            btnRename = new Button();
            lstPreView = new ListBox();
            btnTest = new Button();
            SuspendLayout();
            // 
            // lstOriginalFiles
            // 
            lstOriginalFiles.FormattingEnabled = true;
            lstOriginalFiles.ItemHeight = 17;
            lstOriginalFiles.Location = new Point(14, 16);
            lstOriginalFiles.Margin = new Padding(4);
            lstOriginalFiles.Name = "lstOriginalFiles";
            lstOriginalFiles.Size = new Size(408, 140);
            lstOriginalFiles.TabIndex = 0;
            // 
            // txtNewExpression
            // 
            txtNewExpression.Location = new Point(14, 164);
            txtNewExpression.Margin = new Padding(4);
            txtNewExpression.Name = "txtNewExpression";
            txtNewExpression.Size = new Size(312, 23);
            txtNewExpression.TabIndex = 1;
            // 
            // chkCaseSensitive
            // 
            chkCaseSensitive.AutoSize = true;
            chkCaseSensitive.Location = new Point(14, 195);
            chkCaseSensitive.Margin = new Padding(4);
            chkCaseSensitive.Name = "chkCaseSensitive";
            chkCaseSensitive.Size = new Size(87, 21);
            chkCaseSensitive.TabIndex = 2;
            chkCaseSensitive.Text = "区分大小写";
            chkCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // chkUseRegex
            // 
            chkUseRegex.AutoSize = true;
            chkUseRegex.Location = new Point(14, 225);
            chkUseRegex.Margin = new Padding(4);
            chkUseRegex.Name = "chkUseRegex";
            chkUseRegex.Size = new Size(51, 21);
            chkUseRegex.TabIndex = 3;
            chkUseRegex.Text = "正则";
            chkUseRegex.UseVisualStyleBackColor = true;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(334, 455);
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
            lstPreView.Location = new Point(14, 254);
            lstPreView.Margin = new Padding(4);
            lstPreView.Name = "lstPreView";
            lstPreView.Size = new Size(408, 140);
            lstPreView.TabIndex = 0;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(334, 160);
            btnTest.Margin = new Padding(4);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(88, 30);
            btnTest.TabIndex = 4;
            btnTest.Text = "测试";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnRename_Click;
            // 
            // FormFileRule
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 509);
            Controls.Add(btnTest);
            Controls.Add(btnRename);
            Controls.Add(chkUseRegex);
            Controls.Add(chkCaseSensitive);
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
        private System.Windows.Forms.CheckBox chkCaseSensitive;
        private System.Windows.Forms.CheckBox chkUseRegex;
        private System.Windows.Forms.Button btnRename;
        private ListBox lstPreView;
        private Button btnTest;
    }
}