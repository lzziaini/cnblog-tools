using Cnblog.Tools.Rules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cnblog.Tools
{
    public partial class FormFileRule : Form
    {
        public FormFileRule()
        {
            InitializeComponent();
            Load += FormFileRule_Load;
        }

        private void FormFileRule_Load(object sender, EventArgs e)
        {
            lstOriginalFiles.Items.AddRange(new[]
            {
                "Can Suno Do Metal.mp3",
                "corporate video for Perfectial.mp4",
                "Glass Heart.mp3",
                "Office Space - Promotional Video.mp4"
            });
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            lstPreView.Items.Clear();
            foreach (var item in lstOriginalFiles.Items)
            {
                var originalFileName = item.ToString();
                var newFileName = GetNewFileName(originalFileName);

                lstPreView.Items.Add(newFileName);
            }
        }

        private string GetNewFileName(string originalFileName)
        {
            var expression = txtNewExpression.Text;
            var caseSensitive = chkCaseSensitive.Checked;
            var useRegex = chkUseRegex.Checked;

            if (useRegex)
            {
                var regex = new Regex(expression, caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase);
                var match = regex.Match(originalFileName);
                if (match.Success)
                {
                    return match.Value;
                }
            }
            else
            {
                var pattern = caseSensitive ? expression : expression.ToLower();
                var index = originalFileName.IndexOf(pattern, caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase);
                if (index >= 0)
                {
                    return originalFileName.Substring(index + pattern.Length).TrimStart('.');
                }
            }

            return originalFileName;
        }

        private void btnEnsure_Click(object sender, EventArgs e)
        {

        }
    }
}