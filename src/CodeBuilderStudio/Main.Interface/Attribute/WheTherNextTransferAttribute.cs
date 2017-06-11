/*
 *author:南京.王清培
 *coding time:2011.5.28
 *copyright:快捷速递
 *function:表示构件是否已经在本构件中实现完毕，如果没有实现需要继续向下查找实现的字构件，则需要用该特性标识出来；
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Interface.Attribute
{
    /// <summary>
    /// 表示构件是否已全部实现完毕，不需要继续向下查找本构件公开的接口；
    /// </summary>
    public class WheTherNextTransferAttribute : System.Attribute
    {
        /// <summary>
        /// 获取，是否继续向下查找实现的构件，true:需要向下查找，false:不需要向下查找
        /// </summary>
        public bool IfNextTransfer { get; set; }
        /// <summary>
        /// 如果当前构件未能全部实现，则子构件的程序集的名称
        /// </summary>
        public string ChildAssembly { get; set; }
        /// <summary>
        /// 子构件的入口点，也就是子构件接口；
        /// </summary>
        public string ChildInterface { get; set; }
        /// <summary>
        /// 构造构件实现特性；
        /// </summary>
        public WheTherNextTransferAttribute() { }
    }
}
