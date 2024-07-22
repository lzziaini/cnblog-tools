using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cnblog.Tools.Rules
{

    public class FileRenamer
    {
        private List<IRenameRule> _rules = new List<IRenameRule>();
        public FileRenamer()
        {
            _rules = new List<IRenameRule>();

            AddRule(new MacroDateTimeRule());
            AddRule(new MacroIndexRule());
            AddRule(new MacroOrginFileRule());
        }

        public void AddRule(IRenameRule rule)
        {
            _rules.Add(rule);
        }
        public void RemoveRule(IRenameRule rule)
        {
            _rules.Remove(rule);
        }

        public string RenameFile(string originalFileName, int index, string expression)
        {
            if (!ValidateRules(expression))
            {
                return null;
            }
            if (!ContainsRequiredPattern(expression))
            {
                return null;
            }

            string fileNameWithoutEx = Path.GetFileNameWithoutExtension(originalFileName);
            string extension = Path.GetExtension(originalFileName);

            string result = expression;

            foreach (var rule in _rules)
            {
                result = rule.Apply(fileNameWithoutEx, index, result);
            }

            if (string.IsNullOrEmpty(result))
            {
                return originalFileName;
            }
            else return result + extension;
        }

        public bool ValidateRules(string input)
        {
            string pattern = @"^[^<>:""/\\|?*\x00-\x1F]+$"; // 文件名有效字符的正则表达式

            bool isValidFileName = Regex.IsMatch(input, pattern);

            return true;
        }
        public bool ContainsRequiredPattern(string input)
        {
            var match = _rules.Any(rule => Regex.IsMatch(input, rule.Pattern())); // 检查输入字符串是否匹配至少一个模式

            _rules.ForEach(rule =>
            {
                var pattern = rule.Pattern();
                var res = Regex.IsMatch(input, pattern);
            });

            return match;
        }

    }
}
