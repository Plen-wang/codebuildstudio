/*
 *author:南京.王清培
 *coding time:2011.7.10
 *function:将整个应用程序以公开接口的方式向外传递，本接口是公开实现打开项目的，让构件能无限极的向下延伸；
 *copyright:快捷速递
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Main.Interface
{
    /// <summary>
    /// 打开代码查看委托
    /// </summary>
    /// <param name="content">WeifenLuo.WinFormsUI.Docking.DockContent显示窗口</param>
    public delegate void BrowserFileCodeFrmHandler(WeifenLuo.WinFormsUI.Docking.DockContent content);
    /// <summary>
    /// 设置文件TreeView的节点
    /// </summary>
    /// <param name="filepath">文件的路径</param>
    public delegate void SetProjectNodeHandler(string filepath);
    /// <summary>
    /// 打开项目接口
    /// </summary>
    public interface OpenProject
    {
        /// <summary>
        /// 打开代码查看
        /// </summary>
        event BrowserFileCodeFrmHandler BrowserFileCodeFrmEvent;
        /// <summary>
        /// 设置文件TreeView的节点事件，主程序可以使用该事件来显示提示信息
        /// </summary>
        event SetProjectNodeHandler SetProjectNodeEvent;
        /// <summary>
        /// 打开代码文件
        /// </summary>
        /// <param name="nodetag">节点所绑定的对象</param>
        /// <returns>StringBuilder</returns>
        void BrowserFileCode(object nodetag);
        /// <summary>
        /// 打开项目
        /// </summary>
        /// <param name="tv">绑定TreeView控件</param>
        void OpenProject(System.Windows.Forms.TreeView tv);
        /// <summary>
        /// 项目路径
        /// </summary>
        string ProjectPath { get; set; }
        /// <summary>
        /// 查找指定文件名称的节点
        /// </summary>
        /// <param name="tv">TreeView控件</param>
        void Lookup(TreeView tv);
        /// <summary>
        /// 打开文件所在的目录
        /// </summary>
        /// <param name="nodeobject">节点所绑定的文件逻辑对象</param>
        void OpenFileDir(object nodeobject);
    }
}
