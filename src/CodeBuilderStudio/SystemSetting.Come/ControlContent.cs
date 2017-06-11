/*
 *author:南京.王清培
 *coding time:2011.8.1
 *copyright:快捷速递
 *function:系统设置构件，实现系统设置功能模块。
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Main.Interface.ComeBaseModule;

namespace SystemSetting.Come
{
    /// <summary>
    /// 继承构件基类，没有完全实现构件，继续向下传递实现；
    /// </summary>
    [Main.Interface.Attribute.WheTherNextTransfer(IfNextTransfer = true, ChildAssembly = "SystemSetting.Come.Childe1",
        ChildInterface = "SystemSetting.Interface.NextComeInterface")]
    public class ControlContent : Main.Interface.ComeBaseModule.BaseCome, Main.Interface.SystemSetting
    {
        public ControlContent() { }
        /// <summary>
        /// 重载构造函数，初始化构件的基本属性
        /// </summary>
        /// <param name="comename">构件名称</param>
        /// <param name="loadpath">构件的加载路径</param>
        /// <param name="time">装载时间</param>
        public ControlContent(string comename, string loadpath, DateTime time) : base(comename, loadpath, time) { }

        #region BaseCome成员
        public override void StartCome() { }

        public override void Dispose() { }
        #endregion

        #region SystemSetting 成员
        public Main.Interface.SystemSettingHanlder<Main.Interface.ComeBaseModule.PlugEventArgs> GetCodeThempPath;
        /// <summary>
        /// 该事件需要控制，前端可能频繁订阅该事件，因为每次事件处理过程中都需要前台打开Win32对话框或关于多线程互操作导致跨线程错误。
        /// </summary>
        public event Main.Interface.SystemSettingHanlder<Main.Interface.ComeBaseModule.PlugEventArgs> GetCodeThempPathEvent
        {
            add
            {

                if (GetCodeThempPath == null)
                    GetCodeThempPath += value;
            }
            remove
            {
                if (GetCodeThempPath != null)
                    GetCodeThempPath -= value;
            }
        }
        public void OnGetCodeThempPath()
        {
            Main.Interface.ComeBaseModule.PlugEventArgs plugarg = new SystemSettingArgs();
            GetCodeThempPath(plugarg);
        }
        public event Main.Interface.SystemSettingHanlder<string> CallBackCodeThempPath;
        public void OnCallBackCodeThempPath(string path)
        {
            CallBackCodeThempPath(path);
        }
        public void ShowSettingFrom()
        {
            UnManagerObjectPolling.UnManagerObjectPollingTimeSpanEvent += new UnManagerObjectPollingHandler(UnManagerObjectPolling_UnManagerObjectPollingTimeSpanEvent);
            UnManagerObjectPolling.AddObject("systemsettingobject", this);
            FrmSystemSetting frmsetting = new FrmSystemSetting();
            frmsetting.ShowDialog();
        }

        void UnManagerObjectPolling_UnManagerObjectPollingTimeSpanEvent(Dictionary<string, object> PrivateObjectPolling)
        {
            PrivateObjectPolling.Remove("systemsettingobject");
            PrivateObjectPolling.Add("systemsettingobject", this);
        }
        #endregion
    }
}
