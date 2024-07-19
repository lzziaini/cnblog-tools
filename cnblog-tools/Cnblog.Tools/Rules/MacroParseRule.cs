using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cnblog.Tools.Rules
{
    public class MacroParseRule : IRenameRule
    {
        private readonly string _macro;
        private readonly string _format;
        public MacroParseRule(string macro, string format = "")
        {
            _macro = macro;
            _format = format;
        }
        public string Apply(string fileName, int index, Dictionary<string, string> macros)
        {
            // 根据宏和格式处理文件名
            switch (_macro)
            {
                case "$OriginFileName":
                    return macros["$OriginFileName"];
                case "$FetchFileName":
                    return macros["$FetchFileName"];
                case "$DateTime":
                    return DateTime.Now.ToString(string.IsNullOrEmpty(_format) ? "yyyyMMdd" : _format);
                case "$Index":
                    return index.ToString();
                default:
                    return fileName; // 如果宏不匹配，返回原始文件名
            }
        }
    }
}
