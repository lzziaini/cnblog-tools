using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cnblog.Tools.Rules
{

    public class FileRenamer
    {
        private List<IRenameRule> _rules = new List<IRenameRule>();
        private Dictionary<string, string> _macros = new Dictionary<string, string>();

        public void AddRule(IRenameRule rule)
        {
            _rules.Add(rule);
        }

        public void RemoveRule(IRenameRule rule)
        {
            _rules.Remove(rule);
        }

        public string RenameFile(string originalFileName, int index)
        {
            string result = originalFileName;
            _macros["$OriginFileName"] = originalFileName;
            _macros["$FetchFileName"] = result;

            foreach (var rule in _rules)
            {
                result = rule.Apply(result, index, _macros);
                _macros["$FetchFileName"] = result; // 更新$FetchFileName宏
            }

            return result;
        }

        public bool ValidateRules()
        {
            // 这里应该实现规则的合法性检查，例如正则表达式的正确性等
            // ...
            return true;
        }
    }
}
