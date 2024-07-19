using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cnblog.Tools.Rules
{
    public class NoOperationRule : IRenameRule
    {
        public string Apply(string fileName, int index, Dictionary<string, string> macros)
        {
            // 无操作，直接返回原始文件名
            return fileName;
        }
    }
}
