using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ComeCommonMethod
{
    /// <summary>
    /// Win32相关API封装
    /// </summary>
    public static class Win32Function
    {
        #region 独立功能
        /// <summary>
        /// 加载非托管动态连接库文件到内存，并返回该对象在内存中的地址；
        /// </summary>
        /// <param name="filename">DLL文件路径</param>
        /// <returns>IntPtr内存指针</returns>
        [DllImport("Kernel.dll", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr LoadLibrary(string filename);
        #endregion

        #region 进程间通讯
        /// <summary>
        /// 自定义Windows消息，用来区分消息的类型
        /// </summary>
        const int WM_COPYDATA = 0x004A;
        /// <summary>
        /// 传递的数据结构
        /// </summary>
        public struct SendMessageData
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string SendMessage;
        }
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, int Msg, int wParam, ref SendMessageData msg);
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public static extern int FindWindow(string toclassname, string towindowname);

        #endregion
    }
}
