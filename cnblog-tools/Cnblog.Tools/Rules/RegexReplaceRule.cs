using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cnblog.Tools.Rules
{
    public class RegexReplaceRule : IRenameRule
    {
        private readonly string _pattern;
        private readonly string _replacement;

        public RegexReplaceRule(string pattern, string replacement)
        {
            _pattern = pattern;
            _replacement = replacement;
        }

        public string Apply(string fileName, int index, Dictionary<string, string> macros)
        {
            return Regex.Replace(fileName, _pattern, _replacement);
        }
    }
}
