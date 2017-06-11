/*
 *author:南京.王清培
 *coding time:2011.7.18
 *copyright:快捷速递
 *function:日志管理中心，用来记录相关日志信息；
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ComeCommonMethod
{
    /// <summary>
    /// 日志管理
    /// </summary>
    public static class LogFunction
    {
        /// <summary>
        /// API写ini文件
        /// </summary>
        /// <param name="section">节点</param>
        /// <param name="key">键</param>
        /// <param name="val">值</param>
        /// <param name="filePath">路径</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
    }
}
