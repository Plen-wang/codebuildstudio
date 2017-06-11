using System;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using System.Text;

namespace ScriptEngineKernel
{
    /// <summary>
    /// 程序集Assembly信息
    /// </summary>
    public class DotNetAssemblyInfo
    {
        public DotNetAssemblyInfo() { }

    }
    /// <summary>
    /// 程序集Assembly信息集合
    /// </summary>
    public class DotNetAssemblyInfoCollection : List<DotNetAssemblyInfo>
    {
        public DotNetAssemblyInfoCollection() { }
        private static DotNetAssemblyInfoCollection globallist = new DotNetAssemblyInfoCollection();
        /// <summary>
        /// 获取DotNetAssemblyInfo集合对象
        /// </summary>
        public static DotNetAssemblyInfoCollection GacAssemblyInfoCollection
        {
            get
            {
                lock (globallist)
                {
                    List<string> assemblyname = new List<string>();
                    GetAssemblyNames(assemblyname);
                }
                return globallist;
            }
        }
        /// <summary>
        /// 获取程序集名称
        /// </summary>
        /// <param name="names">返回的名称集合</param>
        private static void GetAssemblyNames(List<string> names)
        {

        }
    }
}
