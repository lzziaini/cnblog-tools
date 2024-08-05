using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cnblog.Tools.Rules
{
    public interface IRenameRule
    {
        string Apply(string fileName, int index, string expression);
        string Pattern();
        string DefaultExample();
    }
}
