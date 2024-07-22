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

        private string GetNewFileName(string originalFileName, int index, string expression)
        {
            string pattern = "";
            string result = expression;

            // 匹配 $datetime(`...`)$ 格式
            pattern = @"\$datetime\(`([^`]+)`\)\$";
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

            // 匹配 $index(`0`)$ 格式
            pattern = @"\$index\(`(\d+)`\)\$"; // 匹配 $index(`数字`)$ 模式的正则表达式
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

            // 匹配 $filename$ 模式的正则表达式
            pattern = @"\$filename\$";
            result = Regex.Replace(result, pattern, m =>
            {
                return originalFileName;
            });

            return result;
        }
        public string Pattern()
        {
            return @"\$filename\$";
        }
    }
}
