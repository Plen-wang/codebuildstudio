using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ThempEdit.Come.Module
{
    /// <summary>
    /// 模板文件集合，用来存放模板文件的对象，通过统一的打开方式浏览文件、编辑文件、保存文件
    /// </summary>
    public class M_EditDomCollection : IEnumerable, IEnumerator
    {
        /// <summary>
        /// 模板文件对象列表
        /// </summary>
        List<M_EditDom> DomList = new List<M_EditDom>();
        /// <summary>
        /// 初始位置为0；
        /// </summary>
        int current = 0;
        public void Add(M_EditDom dom)
        {
            DomList.Add(dom);
        }
        public string[] GetList
        {
            get
            {
                string[] result = new string[DomList.Count];
                for (int i = 0; i < DomList.Count; i++)
                {
                    result[i] = DomList[i].filename;
                }
                return result;
            }
        }
        public M_EditDom this[int index]
        {
            get { return DomList[index]; }
        }
        #region IEnumerable 成员

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        #endregion

        #region IEnumerator 成员

        public object Current
        {
            get { return DomList[current]; }
        }

        public bool MoveNext()
        {
            return DomList.Count < current + 1 ? true : false;
        }

        public void Reset()
        {
            current = 0;
        }

        #endregion
    }
}