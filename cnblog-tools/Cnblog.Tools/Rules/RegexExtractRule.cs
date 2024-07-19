using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cnblog.Tools.Rules
{
    public class RegexExtractRule : IRenameRule
    {
        private readonly string _pattern;

        public RegexExtractRule(string pattern)
        {
            _pattern = pattern;
        }

        public string Apply(string fileName, int index, Dictionary<string, string> macros)
        {
            var match = Regex.Match(fileName, _pattern);
            if (match.Success)
            {
                return match.Groups[1].Value; // 假设提取第一个捕获组
            }
            return fileName; // 如果没有匹配，返回原始文件名
        }
    }
}
