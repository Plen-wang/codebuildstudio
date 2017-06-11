/*
 *author:南京.王清培
 *coding time:2011.7.11
 *copyright:快捷速递
 *function:打开解决方案中的所有文件时，该类对应着csproj文件；DOM思想
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.ComponentModel;

namespace OpenProject.Come.Module
{
    /// <summary>
    /// csproj文件对象
    /// </summary>
    public class M_DomProject : M_DomBase, IEnumerable, IEnumerator
    {
        #region 项目的一些属性
        [Category("数据"), Description("项目的产品版本"), ReadOnly(true)]
        public string ProductVersion { get; set; }
        [Category("数据"), Description("项目在对外时的唯一编号。如将项目公开COM时的唯一编号，在OLE容器中的编号"), ReadOnly(true)]
        public string ProjectGuid { get; set; }
        [Category("数据"), Description("项目最终生成的程序集名称"), ReadOnly(true)]
        public string AssemblyName { get; set; }

        [Category("数据"), Description("项目的根命名空间"), ReadOnly(true)]
        public string RootNameSpace { get; set; }
        [Category("类型"), Description("项目的框架版本"), ReadOnly(true)]
        public string SchemaVersion { get; set; }
        [Category("类型"), Description("类型的输出类型"), ReadOnly(true)]
        public string OutputType { get; set; }
        /// <summary>
        /// 应用列表
        /// </summary>
        public List<string> _reflection = new List<string>();
        /// <summary>
        /// 文件夹列表
        /// </summary>
        public List<M_DomDirectory> _dir = new List<M_DomDirectory>();
        /// <summary>
        /// Cs文件的集合
        /// </summary>
        public List<M_DomCs> CsFileCollection = new List<M_DomCs>();
        #endregion


        private int currentindex = -1;

        #region IEnumerable 成员

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        #endregion

        #region IEnumerator 成员
        [Browsable(false)]
        public object Current
        {
            get { return CsFileCollection[currentindex]; }
        }

        public bool MoveNext()
        {
            currentindex++;
            return currentindex >= CsFileCollection.Count - 1 ? false : true;
        }

        public void Reset()
        {
            currentindex = -1;
        }

        #endregion
    }
}
