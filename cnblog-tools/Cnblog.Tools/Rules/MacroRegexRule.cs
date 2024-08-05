using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cnblog.Tools.Rules
{
    public class MacroRegexRule : IRenameRule
    {
        public MacroRegexRule()
        {
        }

        public string Apply(string fileNameWithoutEx, int index, string expression)
        {
            var regex = new Regex(expression, RegexOptions.None);
            var match = regex.Match(fileNameWithoutEx);
            if (match.Success)
            {
                return match.Value;
            }

            return fileNameWithoutEx; // 如果没有匹配，返回原始文件名
        }

        public string DefaultExample()
        {
            return null;
        }

        public string Pattern()
        {
            return null;
        }
    }
}
