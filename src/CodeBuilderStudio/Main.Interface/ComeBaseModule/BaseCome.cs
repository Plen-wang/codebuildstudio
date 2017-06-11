/*
 *author:南京.王清培
 *coding time:2011.5.28
 *copyright:快捷速递
 *function:构件基类，提供所有构件部分共有功能，所有构件均需要继承该对象
 */
using System;
using System.Collections.Generic;
using System.Text;
using Main.Interface;

namespace Main.Interface.ComeBaseModule
{
    /// <summary>
    /// 泛型委托，
    /// </summary>
    /// <param name="args">方法的签名类型</param>
    public delegate void OnExceptionHandler<T>(T ex);
    /// <summary>
    /// 构件基类，解决所有构件频繁实现StartCome接口，实现部分构件功能
    /// </summary>
    public abstract class BaseCome : ComeStartInterface.StartComeInterface
    {
        #region 构件基本字段、属性
        /// <summary>
        /// 构件名称
        /// </summary>
        protected string _comename = string.Empty;
        /// <summary>
        /// 构件装载路径
        /// </summary>
        protected string _comeloadpath = string.Empty;
        /// <summary>
        /// 构件装载时间
        /// </summary>
        protected DateTime _loadtime;
        /// <summary>
        /// 获取构件名称
        /// </summary>
        public string ComeName
        {
            get { return _comename; }
        }
        /// <summary>
        /// 获取构件装载路径
        /// </summary>
        public string ComeLoadPath
        {
            get { return _comeloadpath; }
        }
        /// <summary>
        /// 构件装载时间
        /// </summary>
        public DateTime LoadTime
        {
            get { return _loadtime; }
        }
        #endregion

        public BaseCome() { }
        /// <summary>
        /// 重载构造函数，初始化构件的基本属性
        /// </summary>
        /// <param name="comename">构件名称</param>
        /// <param name="loadpath">构件的加载路径</param>
        /// <param name="time">装载时间</param>
        public BaseCome(string comename, string loadpath, DateTime time)
        {
            _comename = comename;
            _comeloadpath = loadpath;
            _loadtime = time;
        }

        #region StartComeInterface 成员
        /// <summary>
        /// 构件加载成功时发生
        /// </summary>
        public event OnExceptionHandler<ComeBaseModule.ComeRestException> ComeStartGoodsEvent;
        /// <summary>
        /// 构件退出时发生
        /// </summary>
        public event OnExceptionHandler<ComeBaseModule.ComeRestException> ComeExitGoodsEvent;
        /// <summary>
        /// 构件在内部处理时发生异常
        /// </summary>
        public event OnExceptionHandler<ComeBaseModule.ComeRestException> ComeExceptionEvent;
        /// <summary>
        /// 虚方法，用于触发构件加载成功事件ComeStartGoodsEvent;
        /// </summary>
        public virtual void OnComeStartGoodsEvent(ComeBaseModule.ComeRestException exception)
        {
            ComeStartGoodsEvent(exception);
        }
        /// <summary>
        /// 虚方法，用于触发构件退出成功事件OnComeExitGoodsEvent;
        /// </summary>
        public virtual void OnComeExitGoodsEvent(ComeBaseModule.ComeRestException exception)
        {
            ComeExitGoodsEvent(exception);
        }
        /// <summary>
        /// 虚方法，用于触发构件在内部处理时的异常事件，传递到构件管理中心进行统一记录
        /// </summary>
        /// <param name="exception">异常信息</param>
        public virtual void OnComeExceptionEvent(ComeBaseModule.ComeRestException exception)
        {
            ComeExceptionEvent(exception);
        }
        /// <summary>
        /// 构件启动方法，所有构件均使用该方法进行启动
        /// </summary>
        public abstract void StartCome();

        #endregion
        #region 子构件管理，用于处理所有向下无限传递的子构件能实现父构件为能实现的功能
        /// <summary>
        /// 激活子构件，将当前主构件中的所有子构件加载到内存中，等待后期调用
        /// </summary>
        /// <param name="childtype">主构件对象类型，主构件必须使用Main.Interface.Attribute.WheTherNextTransferAttribute特性标记</param>
        protected void ActiveChildCome(Type childtype)
        {

        }
        #endregion
        #region IDisposable 成员
        /// <summary>
        /// 执行与释放或重置非托管资源相关的应用程序定义的任务。
        /// </summary>
        public abstract void Dispose();

        #endregion

        #region Finalize终结器释放
        protected virtual void Finalize() { }
        #endregion
    }
}
