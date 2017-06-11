/*
 *author:南京.王清培
 *coding time:2011.5.28
 *copyright:快捷速递
 *function:静态事件连，用来连接所有的窗口联动；
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Main.Interface.ComeBaseModule;
using Main.Interface;

namespace CodeBuilderStudio.Main
{
    /// <summary>
    /// 数据源窗口显示表视图委托
    /// </summary>
    /// <param name="content">WeifenLuo.WinFormsUI.Docking.DockContent content对象</param>
    public delegate void ViewTableFrmHandler(WeifenLuo.WinFormsUI.Docking.DockContent content);
    /// <summary>
    /// 数据源窗口显示表视图委托，用来显示子控件
    /// </summary>
    /// <param name="control">UserControl，子控件而不是控件的载体</param>
    /// <param name="parent">控件容器</param>
    public delegate void ViewTableControlHandler(UserControl control, System.Windows.Forms.Control parent);
    /// <summary>
    /// 项目文件窗口显示委托，用来在主窗体与项目窗体之间的联动事件
    /// </summary>
    /// <param name="project">打开项目文件构件接口</param>
    public delegate void BrowserProjectHandler(global::Main.Interface.OpenProject project);
    /// <summary>
    /// 在属性栏中显示选择的对象
    /// </summary>
    /// <param name="displayobject">要显示的对象</param>
    public delegate void DisplayProjectInfoHandler(object displayobject);
    /// <summary>
    /// 主窗口使用单件生成构件，
    /// </summary>
    /// <returns>SingleBuilder对象</returns>
    public delegate SingleBuilder MainOperationSingleBuilderComeHandler();
    /// <summary>
    /// 单个参数的泛型委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="t"></param>
    public delegate void SingleParameterHandler<T>(T t);
    /// <summary>
    /// 全局静态事件链
    /// </summary>
    public static class WinFrmLifecycleEvent
    {
        /// <summary>
        /// 显示表视图事件
        /// </summary>
        public static event ViewTableFrmHandler ViewTableFrmEvent;
        /// <summary>
        /// 触发ViewTableFrmEvent事件，以显示表视图
        /// </summary>
        /// <param name="content">WeifenLuo.WinFormsUI.Docking.DockContent content</param>
        public static void OnViewTableFrmEvent(WeifenLuo.WinFormsUI.Docking.DockContent content)
        {
            ViewTableFrmEvent(content);
        }
        /// <summary>
        /// 显示子控件事件
        /// </summary>
        public static event ViewTableControlHandler ViewTableControlEvent;
        /// <summary>
        /// 触发显示子控件事件
        /// </summary>
        /// <param name="control">子控件</param>
        public static void OnViewTableControlEvent(UserControl control, System.Windows.Forms.Control parent)
        {
            ViewTableControlEvent(control, parent);
        }
        public static event EventHandler MainViewFrmCloseEvent;
        public static void OnMainViewFrmCloseEvent(object sender, EventArgs e)
        {
            MainViewFrmCloseEvent(sender, e);
        }
        public static event BrowserProjectHandler BrowserProjectEvent;
        public static void OnBrowserProjectEvent(global::Main.Interface.OpenProject project)
        {
            BrowserProjectEvent(project);
        }
        public static event ViewTableFrmHandler ViewCodeFrmEvent;
        public static void OnViewCodeFrmEvent(WeifenLuo.WinFormsUI.Docking.DockContent content)
        {
            ViewCodeFrmEvent(content);
        }
        public static event DisplayProjectInfoHandler DispalyProjectInfoEvent;
        public static void OnDisplayProjectInfoEvent(object o)
        {
            DispalyProjectInfoEvent(o);
        }
        /// <summary>
        /// 全局关闭事件，主程序执行关闭命令所有子窗口必须进行相应
        /// </summary>
        public static event EventHandler CloseGlobalEvent;
        public static void OnCloseGlobalEvent(object sender, EventArgs args)
        {
            CloseGlobalEvent(sender, args);
        }
        /// <summary>
        /// 主窗口使用单件生成构件，向数据源窗口借用
        /// </summary>
        public static event MainOperationSingleBuilderComeHandler OnMainOperationSingleBuilderComeEvent;
        public static SingleBuilder OnMainOperationSingleBuilderCome()
        {
            return OnMainOperationSingleBuilderComeEvent.Invoke();
        }
        #region 输出窗口的事件链
        private static SingleParameterHandler<string> _outfromshowinfo;
        public static event SingleParameterHandler<string> OutFromShowInfo
        {
            add
            {
                if (_outfromshowinfo == null)
                    _outfromshowinfo += value;
            }
            remove
            {
                if (_outfromshowinfo != null)
                    _outfromshowinfo -= value;
            }
        }
        public static void OnOutFromShowInfo(string info)
        {
            if (_outfromshowinfo != null)
                if (_outfromshowinfo.GetInvocationList().Length > 0)
                    _outfromshowinfo(info);
        }
        #endregion
        #region 错误窗口的事件链
        private static SingleParameterHandler<string> _errfromshowinfo;
        public static event SingleParameterHandler<string> ErrFromShowInfo
        {
            add
            {
                if (_errfromshowinfo == null)
                    _errfromshowinfo += value;
            }
            remove
            {
                if (_errfromshowinfo != null)
                    _errfromshowinfo -= value;
            }
        }
        public static void OnErrFromShowInfo(string info)
        {
            if (_errfromshowinfo != null)
                if (_errfromshowinfo.GetInvocationList().Length > 0)
                    _errfromshowinfo(info);
        }
        #endregion
    }
}