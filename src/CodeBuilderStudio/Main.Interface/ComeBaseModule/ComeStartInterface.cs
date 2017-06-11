/*
 *author:南京.王清培
 *coding time:2011.5.28
 *copyright:快捷速递
 *function:所有构件均需要实现的接口，该接口规范了所有构件的启动条件；
 */
using System;
using System.Collections.Generic;
using System.Text;
using Main.Interface.ComeBaseModule;

namespace Main.Interface.ComeStartInterface
{
    /// <summary>
    /// 构件启动接口，该接口包含了所有构件启动和退出时的事件方法。
    /// </summary>
    public interface StartComeInterface : IDisposable
    {
        /// <summary>
        /// 构件启动方法，所有的构件在通过构件核心管理器PlugManager.PlugKernelManager对象
        /// 进行启动时，都会调用这个方法进行本构件的启动过程；
        /// </summary>
        void StartCome();
        /// <summary>
        /// 构件启动成功后的事件，可订阅获取构件启动过程中的相关日志信息；
        /// </summary>
        /// <exception cref="Exception.ComeLoadException">事件在使用时抛出的异常对象</exception>
        event OnExceptionHandler<ComeBaseModule.ComeRestException> ComeStartGoodsEvent;
        /// <summary>
        /// 构件退出成功后的事件，可订阅获取构件退出后的相关信息；
        /// </summary>
        /// <exception cref="Exception.ComeExitException">事件在使用时抛出的异常对象</exception>
        event OnExceptionHandler<ComeBaseModule.ComeRestException> ComeExitGoodsEvent;

    }
}
