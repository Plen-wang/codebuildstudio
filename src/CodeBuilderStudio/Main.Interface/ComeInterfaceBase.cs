/*
 *author:南京.王清培
 *coding time:2011.10.19
 *function:构件基础接口，不同于构件接口，该接口是以业务构件为主；
 *copyright:快捷速递
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Interface
{
    /// <summary>
    /// 构件打开对话框委托，在每个构件内部均需要打开对话框的可能性。
    /// </summary>
    /// <typeparam name="T">要传输的类型</typeparam>
    /// <param name="t">要传输的类型实例</param>
    public delegate void OpenHandler<T>(T t);
    /// <summary>
    /// 要求主程序显示构件窗口
    /// </summary>
    /// <typeparam name="T">要显示的窗口类型</typeparam>
    /// <param name="t">窗口实例</param>
    public delegate void ShowFrmHandler<T>(T t);
    /// <summary>
    /// 构件基础接口，定义个够构件均需要实现的一些常用功能
    /// </summary>
    public interface ComeInterfaceBase
    {
        /// <summary>
        /// 打开文件浏览对话框，构件需要主程序调用文件浏览对话框
        /// </summary>
        event OpenHandler<string> OpenFileDialog;
        /// <summary>
        /// 主程序已经成功获取到用户浏览的文件名称
        /// </summary>
        event OpenHandler<string> SendFileDialog;
        /// <summary>
        /// 构件要求主窗口显示构件内部的IDockContent对象。通常作为内嵌窗口展示。
        /// </summary>
        event ShowFrmHandler<ComeBaseModule.PlugEventArgs> ShowFrmEvent;
        /// <summary>
        /// 让外部触发SendFileDialog事件
        /// </summary>
        /// <param name="sendstring">要发送到构件内部的路径字符串</param>
        void OnSendFileDialog(string sendstring);
        /// <summary>
        /// 让构件入口点能与触发事件对象消耦
        /// </summary>
        void OnOpenFileDialog();
    }
}
