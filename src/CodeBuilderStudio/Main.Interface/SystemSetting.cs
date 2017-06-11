using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Interface
{
    /// <summary>
    /// 系统设置泛型委托。
    /// </summary>
    /// <typeparam name="T">传递的Type类型</typeparam>
    /// <param name="t">T的实例</param>
    public delegate void SystemSettingHanlder<T>(T t);
    /// <summary>
    /// 系统设置公开接口
    /// </summary>
    public interface SystemSetting
    {
        /// <summary>
        /// 需要前台传递模板路径过来，通过触发这个事件
        /// </summary>
        event SystemSettingHanlder<Main.Interface.ComeBaseModule.PlugEventArgs> GetCodeThempPathEvent;
        /// <summary>
        /// 回调事件，发送模板路径给构件
        /// </summary>
        event SystemSettingHanlder<string> CallBackCodeThempPath;
        /// <summary>
        /// 打开设置窗口
        /// </summary>
        void ShowSettingFrom();
        /// <summary>
        /// 在前台触发CallBackCodeThempPath事件，让构件获取到模板路径字符串
        /// </summary>
        /// <param name="path">模板路径字符串</param>
        void OnCallBackCodeThempPath(string path);
    }
}
