using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cnblog.Tools.Models
{
    public class ProcessConfig
    {
        /// <summary>
        /// 是否保留源文件
        /// </summary>
        public bool RetainOriginFile { get; set; }
        /// <summary>
        /// 文件保存的根路径
        /// </summary>
        public string FileSaveRootFloder { get; set; }
        /// <summary>
        /// 是否保留源文件目录层次
        /// </summary>
        public bool RetainFilesRelationship { get; set; }
        /// <summary>
        /// 文件名表达式
        /// </summary>
        public string FileRenameExpression { get; set; }
    }
}
