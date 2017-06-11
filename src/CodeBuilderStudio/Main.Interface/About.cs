/*
 *author:南京.王清培
 *coding time:2011.9.10
 *function:将整个应用程序以公开接口的方式向外传递，本接口是公开实现数据源时要实现的，让构件能无限极的向下延伸；
 *copyright:快捷速递
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Interface
{
    /// <summary>
    /// 开始生成代码接口
    /// </summary>
    public interface About
    {
        /// <summary>
        /// 显示关于窗体
        /// </summary>
        void ShowAboutFrm();
    }
}
