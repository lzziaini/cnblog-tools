using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cnblog.Tools.Rules
{
    public class MacroDateTimeRule : IRenameRule
    {
        public MacroDateTimeRule()
        {
        }
        public string Apply(string fileNameWithoutEx, int index, string expression)
        {
            string pattern = "";
            string result = expression;

            // 匹配 $datetime(`...`)$ 格式
            pattern = Pattern();
            result = Regex.Replace(result, pattern, m =>
            {
                string format = m.Groups[1].Value;
                //.Replace("yyyy", "yyyy")
                //.Replace("MM", "MM")
                //.Replace("dd", "dd")
                //.Replace("hh", "HH") // 24小时制
                //.Replace("mm", "mm")
                //.Replace("ss", "ss")
                //.Replace("_", " "); // 替换占位符为实际空格

                try
                {
                    // 格式化当前日期时间
                    return DateTime.Now.ToString(format, CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    // 如果格式字符串无效，返回原始匹配字符串
                    return m.Value;
                }
            });

            return result;
        }

        public string Pattern()
        {
            return @"\$datetime\(`([^`]+)`\)\$";
        }
    }
}
