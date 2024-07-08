namespace Cnblog.Tools
{
    partial class UcPicProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPicProcess));
            panel1 = new Panel();
            btnSelectFold = new Button();
            comboxPath = new ComboBox();
            splitContainer1 = new SplitContainer();
            treeViewFolder = new TreeView();
            IconList = new ImageList(components);
            panel4 = new Panel();
            listboxPreProcessFiles = new ListBox();
            panel3 = new Panel();
            btnClearDrogFiles = new Button();
            btnProcessFile = new Button();
            textConsole = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuItemNewDraft = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSelectFold);
            panel1.Controls.Add(comboxPath);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
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
            splitContainer1.Location = new Point(3, 34);
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
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Controls.Add(panel3);
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
            // panel4
            // 
            panel4.AllowDrop = true;
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(listboxPreProcessFiles);
            panel4.Location = new Point(8, 9);
            panel4.Margin = new Padding(2, 3, 2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(584, 118);
            panel4.TabIndex = 3;
            panel4.Visible = false;
            panel4.Paint += panel4_Paint;
            // 
            // listboxPreProcessFiles
            // 
            listboxPreProcessFiles.Dock = DockStyle.Fill;
            listboxPreProcessFiles.FormattingEnabled = true;
            listboxPreProcessFiles.ItemHeight = 17;
            listboxPreProcessFiles.Location = new Point(0, 0);
            listboxPreProcessFiles.Name = "listboxPreProcessFiles";
            listboxPreProcessFiles.Size = new Size(584, 118);
            listboxPreProcessFiles.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClearDrogFiles);
            panel3.Controls.Add(btnProcessFile);
            panel3.Location = new Point(8, 130);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(575, 30);
            panel3.TabIndex = 2;
            // 
            // btnClearDrogFiles
            // 
            btnClearDrogFiles.Location = new Point(415, 3);
            btnClearDrogFiles.Name = "btnClearDrogFiles";
            btnClearDrogFiles.Size = new Size(75, 23);
            btnClearDrogFiles.TabIndex = 1;
            btnClearDrogFiles.Text = "清理";
            btnClearDrogFiles.UseVisualStyleBackColor = true;
            btnClearDrogFiles.Click += btnClearDrogFiles_Click;
            // 
            // btnProcessFile
            // 
            btnProcessFile.Location = new Point(496, 3);
            btnProcessFile.Name = "btnProcessFile";
            btnProcessFile.Size = new Size(75, 23);
            btnProcessFile.TabIndex = 0;
            btnProcessFile.Text = "处理";
            btnProcessFile.UseVisualStyleBackColor = true;
            btnProcessFile.Click += btnProcessFile_Click;
            // 
            // textConsole
            // 
            textConsole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textConsole.BackColor = Color.White;
            textConsole.ForeColor = Color.White;
            textConsole.Location = new Point(8, 163);
            textConsole.Margin = new Padding(2, 3, 2, 3);
            textConsole.Multiline = true;
            textConsole.Name = "textConsole";
            textConsole.ScrollBars = ScrollBars.Both;
            textConsole.Size = new Size(585, 390);
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
            panel2.Size = new Size(584, 118);
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
            // UcPicProcess
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "UcPicProcess";
            Size = new Size(908, 593);
            Load += UserControl_Load;
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
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
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuItemNewDraft;
        private Panel panel3;
        private Button btnProcessFile;
        private Button btnClearDrogFiles;
        private Panel panel4;
        private ListBox listboxPreProcessFiles;
    }
}