using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cnblog.Tools.Rules
{
    public class MacroOrginFileRule : IRenameRule
    {
        public string Apply(string fileNameWithoutEx, int index, string expression)
        {
            string pattern = "";
            string result = expression;

            // 匹配 $filename$ 模式的正则表达式
            pattern = Pattern();
            result = Regex.Replace(result, pattern, m =>
            {
                return fileNameWithoutEx;
            });

            return result;
        }

        public string Pattern()
        {
            return @"\$filename\$";
        }

        public string DefaultExample()
        {
            return @"$filename$";
        }
    }
}
