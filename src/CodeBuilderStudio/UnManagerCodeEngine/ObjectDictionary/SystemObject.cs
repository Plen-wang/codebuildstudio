using System;
using System.Collections.Generic;
using System.Text;

namespace UnManagerCodeEngine.ObjectDictionary
{
    /// <summary>
    /// 系统内部变量，对应着模板中的System标记
    /// </summary>
    public class SystemObject
    {
        /// <summary>
        /// 当天时间
        /// </summary>
        public string CurrentDayTime
        {
            get { return DateTime.Now.ToString("yyyy-MM-dd"); }
        }
        /// <summary>
        /// 系统默认命名空间
        /// </summary>
        public string DefaultNameSpace
        {
            get { return SystemDefault.Default.DefaultNameSpace; }
        }
    }
}
