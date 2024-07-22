using Cnblog.Tools.Rules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cnblog.Tools
{
    public partial class FormFileRule : Form
    {

        readonly string defauleExpression = new MacroOrginFileRule().Pattern();
        string _finallExpression;
        public FormFileRule()
        {
            InitializeComponent();
            Load += FormFileRule_Load;
        }

        public void SetOriginals(List<string> strings)
        {
            lstOriginalFiles.Items.Clear();
            if(strings != null)
                lstOriginalFiles.Items.AddRange(strings.ToArray());
        }
        public void SetOriginals(string[] strings)
        {
            lstOriginalFiles.Items.Clear();
            if (strings != null)
                lstOriginalFiles.Items.AddRange(strings);
        }
        public string GetFinallExpression()
        {
            return _finallExpression;
        }

        private void FormFileRule_Load(object sender, EventArgs e)
        {
            SetOriginals(new string[]
            {
                "Can Suno Do Metal.mp3",
                "corporate video for Perfectial.mp4",
                "Glass Heart.mp3",
                "Office Space - Promotional Video.mp4"
            });
        }
        private void btnRename_Click(object sender, EventArgs e)
        {
            DoTest();
        }
        private void btnEnsure_Click(object sender, EventArgs e)
        {
            if (!DoTest())
            {
                _finallExpression = defauleExpression;
            }
            else _finallExpression = txtNewExpression.Text;
        }

        private bool DoTest()
        {
            lstPreView.Items.Clear();
            FileRenamer fileRenamer = new FileRenamer();
            var expression = txtNewExpression.Text;

            bool test = true;
            foreach (var item in lstOriginalFiles.Items)
            {
                var originalFileName = item.ToString();
                var index = lstOriginalFiles.Items.IndexOf(item);

                var newFileName = fileRenamer.RenameFile(originalFileName, index, expression);

                if (string.IsNullOrEmpty(newFileName))
                {
                    test = false;
                    lstPreView.Items.Add(originalFileName);
                }
                else lstPreView.Items.Add(newFileName);
            }

            return test;
        }
    }
}