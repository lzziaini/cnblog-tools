using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cnblog.Tools.Rules
{
    public class MacroIndexRule : IRenameRule
    {
        public MacroIndexRule()
        {
        }

        public string Apply(string fileNameWithoutEx, int index, string expression)
        {
            string pattern = "";
            string result = expression;

            // 匹配 $index(`0`)$ 格式
            pattern = Pattern();// 匹配 $index(`数字`)$ 模式的正则表达式
            result = Regex.Replace(result, pattern, m =>
            {
                string format = m.Groups[1].Value;
                try
                {
                    var startIndex = int.Parse(format);
                    return (startIndex + index).ToString();
                }
                catch (FormatException)
                {
                    return index.ToString();
                }
            });

            return result;
        }

        public string Pattern()
        {
            return @"\$index\(`(\d+)`\)\$";
        }
        public string DefaultExample()
        {
            return @"$index(`0`)$";
        }
    }
}
