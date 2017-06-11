/*
 *author:南京.王清培
 *coding time:2011.8.3
 *function:将整个应用程序以公开接口的方式向外传递，本接口是公开实现模板编辑要实现的，让构件能无限极的向下延伸；
 *copyright:快捷速递
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace Main.Interface
{
    /// <summary>
    /// 模板编辑上下文泛型委托
    /// </summary>
    /// <typeparam name="T">ThempEdit接口类型</typeparam>
    /// <typeparam name="U">Main.Interface.ComeBaseModule.PlugEventArgs</typeparam>
    /// <param name="sender">ThempEdit接口所引用的对象</param>
    /// <param name="args">事件所传递的参数，可以通过GetArgs()抽象方法获取参数</param>
    public delegate void ParameterHander<T, U>(T sender, U args) where T : ThempEdit;
    /// <summary>
    /// 主程序公开编辑模板接口，供各构件和子构件实现。
    /// </summary>
    public interface ThempEdit : ISynchronizeInvoke
    {
        /// <summary>
        /// 利用泛型委托定义打开模板编辑视图事件，让主程序能及时的在界面上进行呈现
        /// </summary>
        event ParameterHander<ThempEdit, Main.Interface.ComeBaseModule.PlugEventArgs> OpenEditViewEvent;
        /// <summary>
        /// 利用泛型委托定义打开代码模板事件，让主程序能在状态栏中显示路径等信息
        /// </summary>
        event ParameterHander<ThempEdit, Main.Interface.ComeBaseModule.PlugEventArgs> OpenEditCodeEvent;
        /// <summary>
        /// 后台构件要求显示代码Demo
        /// </summary>
        event ParameterHander<ThempEdit, Main.Interface.ComeBaseModule.PlugEventArgs> ShowDemoEvent;
        /// <summary>
        /// 自定义异步操作方法，ISynchronizeInvoke在委托的试用下有点问题。
        /// </summary>
        /// <param name="winformcontext">WindowsFormsSynchronizationContext同步上下文</param>
        /// <param name="callbackmethod">SendOrPostCallback安全的回调委托</param>
        void SynchInvoke(WindowsFormsSynchronizationContext winformcontext, SendOrPostCallback callbackmethod);
    }
}
