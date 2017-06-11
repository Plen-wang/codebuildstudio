/*
 *author:南京.王清培
 *coding time:2011.5.28
 *copyright:快捷速递
 *function:所有构件在内部处理过程中发生错误后，均要用该对象进行返回，子构件可以进行继承重写；
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Interface.ComeBaseModule
{
    /// <summary>
    /// 构件处理错误异常对象，所有的构件对自己的内部处理所抛出的异常均要以该类作为基础
    /// </summary>
    public class ComeRestException : System.Exception
    {
        /// <summary>
        /// 发生异常构件的名称
        /// </summary>
        private string _comename = string.Empty;
        /// <summary>
        /// 异常消息
        /// </summary>
        private string _messageinfo = string.Empty;
        /// <summary>
        /// 获取异常消息
        /// </summary>
        public string MessageInfo
        {
            get { return _messageinfo; }
        }
        /// <summary>
        /// 获取发生异常的构件名称
        /// </summary>
        public string ComeName
        {
            get { return _comename; }
        }
        /// <summary>
        /// 构造异常对象该对象来自System.Exception派生类
        /// </summary>
        /// <param name="meinfo">异常消息</param>
        /// <param name="comename">构件名称</param>
        public ComeRestException(string meinfo, string comename)
        {
            _messageinfo = meinfo;
            _comename = comename;
        }
    }
}
