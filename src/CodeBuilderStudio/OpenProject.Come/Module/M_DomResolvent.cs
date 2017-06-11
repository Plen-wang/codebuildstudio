/*
 *author:南京.王清培
 *coding time:2011.7.11
 *copyright:快捷速递
 *function:打开解决方案中的所有文件时，该类对应着sln文件；DOM思想
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.ComponentModel;

namespace OpenProject.Come.Module
{
    /// <summary>
    /// sln文件对象
    /// </summary>
    public class M_DomResolvent : M_DomBase, IEnumerator, IEnumerable
    {
        #region 解决方案的一些属性
        [Category("数据"), Description("解决方案中的项目数量"), ReadOnly(true)]
        public int ProjectCount { get { return ProjectCollection.Count; } }

        public List<M_DomProject> ProjectCollection;

        #endregion

        [Browsable(false), ReadOnly(true)]
        private int currentindex = -1;

        #region IEnumerable 成员

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        #endregion

        #region IEnumerator 成员
        [Browsable(false)]
        public object Current
        {
            get { return ProjectCollection[currentindex]; }
        }
        [Browsable(false)]
        public bool MoveNext()
        {
            currentindex++;
            return currentindex >= ProjectCollection.Count ? false : true;
        }
        [Browsable(false)]
        public void Reset()
        {
            currentindex = -1;
        }

        #endregion

    }
}
