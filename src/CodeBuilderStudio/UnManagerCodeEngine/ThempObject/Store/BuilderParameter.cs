using System;
using System.Collections.Generic;
using System.Text;

namespace UnManagerCodeEngine
{
    /// <summary>
    /// 表示存储过程的参数
    /// </summary>
    public class BuilderParameter
    {
        /// <summary>
        /// 参数名称
        /// </summary>
        public string ParamName { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 长度
        /// </summary>
        public int ParamLeng { get; set; }
        /// <summary>
        /// 是否输出
        /// </summary>
        public int isoutput { get; set; }
    }
}
