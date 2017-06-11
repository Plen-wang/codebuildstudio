using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.ComponentModel;

namespace OpenProject.Come.Module
{
    /// <summary>
    /// 目录的类型
    /// </summary>
    public enum DirType
    {
        /// <summary>
        /// 程序集属性文件夹
        /// </summary>
        Propertties,
        Common
    }
    public class M_DomDirectory : M_DomBase, IEnumerable, IEnumerator
    {
        #region 文件夹的一些属性
        /// <summary>
        /// Cs文件的集合
        /// </summary>
        public List<M_DomCs> CsFileCollection = new List<M_DomCs>();
        /// <summary>
        /// 目录集合
        /// </summary>
        public List<Module.M_DomDirectory> DirCollection = new List<M_DomDirectory>();
        /// <summary>
        /// 文件夹的类型
        /// </summary>
        public DirType DirectoryType = DirType.Common;
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
