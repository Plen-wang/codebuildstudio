/*
 *author:南京.王清培
 *coding time:2011.8.1
 *function:将整个应用程序以公开接口的方式向外传递，本接口是公开实现单件代码生成时要实现的，让构件能无限极的向下延伸；
 *copyright:快捷速递
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Main.Interface
{
    /// <summary>
    /// 打开Win32文件浏览对话框
    /// </summary>
    public enum BrowserActivateType
    {
        /// <summary>
        /// 构件调用主窗口
        /// </summary>
        front,
        /// <summary>
        /// 主窗口反向回调，必须是线程安全的，或者使用同步上下文进行安全的调用。
        /// </summary>
        callback
    }
    /// <summary>
    /// 文件、文件夹浏览委托，可以通用其他事件。
    /// </summary>
    /// <typeparam name="T">调用的顺序</typeparam>
    /// <typeparam name="U">要传递的类型</typeparam>
    /// <param name="t">要传递实例</param>
    public delegate void BrowserSaveDirectoryHandler<T, U>(U u);
    /// <summary>
    /// 单件代码生成接口，用来公开主程序单件生成的代码选项
    /// </summary>
    public interface SingleBuilder : ComeBaseModule.OutInputInterface
    {
        /// <summary>
        /// 生成的数据源类型
        /// </summary>
        Main.Interface.DataSourceType BuilderSourceType { get; set; }
        /// <summary>
        /// 上下文数据源,打开的所有表信息
        /// </summary>
        List<string> CurrentDataTableSource { get; set; }
        /// <summary>
        /// 打开对话框事件，构件调用。
        /// </summary>
        event BrowserSaveDirectoryHandler<BrowserActivateType, object> BrowserSaveDirectoryFrontEvent;
        /// <summary>
        /// 对话框成功关闭，已获取到文件名称或者目录的名称。
        /// </summary>
        event BrowserSaveDirectoryHandler<BrowserActivateType, string> BrowserSaveDirectoryCallBackEvent;
        /// <summary>
        /// 打开单件生成代码视图
        /// </summary>
        /// <param name="dt">要生成的数据源</param>
        void OpenSingleBuilderView(DataTable dt);
        /// <summary>
        /// 触发对话框回传事件BrowserSaveDirectoryCallBackEvent
        /// </summary>
        /// <param name="path"></param>
        void OnBrowserSaveDirectoryCallBackEvent(string path);
        /// <summary>
        /// 打开多单件代码视图窗口
        /// </summary>
        void OpenMuilterSingleBuilderFrm();
        /// <summary>
        /// 浏览文件保存路径
        /// </summary>
        event BrowserSaveDirectoryHandler<BrowserActivateType, StringBuilder> BrowserSaveFolder;
        /// <summary>
        /// 打开文件夹浏览对话框
        /// </summary>
        /// <param name="path">引用路径</param>
        void OpenFolderBrowserDialog(StringBuilder path);
        /// <summary>
        /// 对当前数据源的引用
        /// </summary>
        Main.Interface.DataSourceOpen CurrentDataSource { set; get; }
    }
}
