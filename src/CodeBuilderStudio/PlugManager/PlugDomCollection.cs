/*
 *author:南京.王清培
 *coding time:2011.6.12
 *copyright:快捷速递
 *function:构件文档对象模型对象集合，包装所有构件DOM对象；
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace PlugManager
{
    /// <summary>
    /// 构件对象集合，PlugDom对象容器
    /// </summary>
    public class PlugDomCollection : IEnumerable, IEnumerator
    {
        /// <summary>
        /// 存放DOM对象集合
        /// </summary>
        private List<PlugDom> domlist = new List<PlugDom>();
        /// <summary>
        /// 当前索引
        /// </summary>
        private int currentindex;
        /// <summary>
        /// 根据索引访问集合成员
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns>PlugDom构件对象</returns>
        public PlugDom this[int index]
        {
            get { return domlist[index]; }
        }
        /// <summary>
        /// 根据索引访问集合成员
        /// </summary>
        /// <param name="xmlnamespace">构件的命名空间</param>
        /// <returns>PlugDom构件对象</returns>
        public PlugDom this[string xmlnamespace]
        {
            get
            {
                foreach (PlugDom dom in domlist)
                {
                    if (dom.XmlNameSpace == xmlnamespace)
                        return dom;
                }
                return null;
            }
        }
        /// <summary>
        /// 获取集合中的当前元素。
        /// </summary>
        public object Current
        {
            get
            {
                return domlist[currentindex];
            }
        }
        /// <summary>
        /// 将枚举数推进到集合的下一个元素。
        /// </summary>
        /// <returns>如果枚举数成功地推进到下一个元素，则为 true；如果枚举数越过集合的结尾，则为 false。</returns>
        public bool MoveNext()
        {
            currentindex++;
            if (currentindex >= domlist.Count)
            {
                currentindex = -1;
                return false;
            }
            else
                return true;

        }
        /// <summary>
        /// 将枚举数设置为其初始位置，该位置位于集合中第一个元素之前。
        /// </summary>
        public void Reset()
        {
            currentindex = 0;
        }
        /// <summary>
        ///  获取可用于循环访问集合的 System.Collections.IEnumerator 对象
        /// </summary>
        /// <returns>本对象，该方法通常是由系统调用</returns>
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        /// <summary>
        /// 加对象添加到PlugDomCollection的末尾处
        /// </summary>
        /// <param name="dom">PlugDom</param>
        public void Add(PlugDom dom)
        {
            domlist.Add(dom);
        }
    }
}
