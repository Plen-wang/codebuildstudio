/*
 *author:南京.王清培
 *coding time:2011.5.29
 *copyright:快捷速递
 *function:整个构件系统的核心，管理整个系统架构，该对象主要负责构件的加载，管理相关任务；
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using System.Xml;
using System.IO;

namespace PlugManager
{
    #region PlugKernelManager使用的委托类型
    /// <summary>
    /// 管理器委托，加载构件事件委托
    /// </summary>
    /// <param name="comename">构件名称</param>
    public delegate void ComeLoadHander(string comename);
    /// <summary>
    /// 管理器委托，构件退出事件委托，监督构件的资源释放问题
    /// </summary>
    /// <param name="comename">构件名称</param>
    public delegate void ComeExitHander(string comename);
    /// <summary>
    /// 管理器委托，构件入口，使用委托断开堆栈关系
    /// </summary>
    public delegate void ComeRunHandler();
    #endregion

    #region PlugKernelManager引擎
    /// <summary>
    /// 1.构件系统核心管理器引擎，负责启动构件系统，将程序中的所有构件进行组装；
    /// 2.通过读取配置文件进行DOM转换，根据对象进行判断构件是否是无限级蔓延构件；
    /// 3.构件系统核心管理器引擎，统一协调构件的整个生命周期事件，在使用完成后进行资源释放；
    /// </summary>
    public static class PlugKernelManager
    {
        #region 字段属性
        /// <summary>
        /// 构件集合
        /// </summary>
        private static PlugDomCollection domcollection;
        /// <summary>
        /// 构件路径，该路径在系统启动时就确定是不允许改动；
        /// </summary>
        private static readonly string _comeloadpath = string.Empty;
        /// <summary>
        /// 构件开始加载时事件
        /// </summary>
        public static event ComeLoadHander ComeLoadEvent;
        /// <summary>
        /// 构件退出时事件
        /// </summary>
        public static event ComeExitHander ComeExitEvent;
        /// <summary>
        /// 管理XML命名空间
        /// </summary>
        private static XmlNamespaceManager XmlNsManager;
        #endregion

        #region PlugKernelManager构造
        /// <summary>
        /// 静态构造函数，初始化系统静态对象
        /// </summary>
        static PlugKernelManager()
        {
            try
            {
                _comeloadpath = Environment.CurrentDirectory;//构件路劲
                //防止空事件触发，导致封送空引用异常
                ComeLoadEvent += new ComeLoadHander(PlugKernelManager_ComeLoadEvent);
                ComeExitEvent += new ComeExitHander(PlugKernelManager_ComeExitEvent);
                XmlNsManager = new XmlNamespaceManager(new NameTable());
                InitXmlNsDomReferences();
            }
            catch (Exception err)
            {

                ComeCommonMethod.LogFunction.WritePrivateProfileString(
                    "GetDomObjectByXmlns", err.Source + "->" + err.TargetSite, err.Message, Environment.CurrentDirectory + "\\PlugManagerLog.ini");
            }
        }

        #region 内部消除事件安全隐患方法，避免事件无订阅导致空引用封送异常，或者在事件链头部加上点初始化操作
        static void PlugKernelManager_ComeExitEvent(string comename)
        {
            //
        }

        static void PlugKernelManager_ComeLoadEvent(string comename)
        {
            //
        }
        #endregion
        #endregion

        #region 公共PlugKernelManager方法，主程序进行调用构件
        /// <summary>
        /// 开始加载构件，以启动系统，该阶段是在主应用程序启动时开始
        /// </summary>
        /// <returns>构件加载是否成功true:成功，false失败</returns>
        public static bool ComeLoad()
        {
            if (GetDomObjectByXmlns())
                return true;
            return false;
        }

        #region IOC依赖注入PlugKernelManage方法，将所有的构件彼此之间的依赖关系通过IOC的设计模式进行分离降耦
        /// <summary>
        /// 主程序发生事件，需要启动相应构件
        /// </summary>
        /// <param name="xmlnamespace">构件所属的命名空间</param>
        /// <returns>本构件加载是否成功true:成功，false失败</returns>
        public static object MainEventProcess(string xmlnamespace)
        {
            try
            {
                PlugDom dom = domcollection[xmlnamespace];
                if (dom == null)
                    throw new System.Exception(
                        "在系统当前上下文构件集合中未能查找出" + xmlnamespace + "命名空间构件，请检查构件配置文件LoadConfig.xml是否进行了相应的设置；");
                ComeLoadEvent(dom.Assembly);//构件初始化成功
                return ReflectionDomObject(dom);//通过反射DLL文件，启动实现构件
            }
            catch (Exception err)
            {
                ComeCommonMethod.LogFunction.WritePrivateProfileString(
                    "MainEventProcess", err.Source + "->" + err.TargetSite, err.Message, Environment.CurrentDirectory + "\\PlugManagerLog.ini");
                return null;
            }
        }
        /// <summary>
        /// 主程序发生事件，释放构件资源
        /// </summary>
        /// <param name="comeobject">构件对象</param>
        public static void MainDisposeProcess(object comeobject)
        {
            try
            {
                (comeobject as Main.Interface.ComeBaseModule.BaseCome).Dispose();
                ComeExitEvent((comeobject as Main.Interface.ComeBaseModule.BaseCome).ComeName);
            }
            catch (Exception err)
            {
                ComeCommonMethod.LogFunction.WritePrivateProfileString(
                    "MainDisposeProcess", err.Source + "->" + err.TargetSite, err.Message, Environment.CurrentDirectory + "\\PlugManagerLog.ini");
            }
        }
        #endregion
        #endregion

        #region 私有PlugKernelManager方法，主要用来初始化一些操作
        /// <summary>
        /// 内部方法，初始化构件配置文件LoadConfig.xml中的所有命名空间与DOM对象的映射关系
        /// </summary>
        private static void InitXmlNsDomReferences()
        {
            XmlNsManager.AddNamespace("R", "http://www.emed.cc/CodeBuilderStudio");
            XmlNsManager.AddNamespace("F", "http://www.emed.cc/CodeBuilderStudio/Details");
            XmlNsManager.AddNamespace("Ab", "http://www.emed.cc/CodeBuilderStudio/Details/About");
            XmlNsManager.AddNamespace("Cl", "http://www.emed.cc/CodeBuilderStudio/Details/Close");
            XmlNsManager.AddNamespace("Com", "http://www.emed.cc/CodeBuilderStudio/Details/ComplexBuilder");
            XmlNsManager.AddNamespace("Data", "http://www.emed.cc/CodeBuilderStudio/Details/DataSourceOpen");
            XmlNsManager.AddNamespace("Ex", "http://www.emed.cc/CodeBuilderStudio/Details/Exit");
            XmlNsManager.AddNamespace("He", "http://www.emed.cc/CodeBuilderStudio/Details/Helper");
            XmlNsManager.AddNamespace("Ne", "http://www.emed.cc/CodeBuilderStudio/Details/NewProject");
            XmlNsManager.AddNamespace("Oe", "http://www.emed.cc/CodeBuilderStudio/Details/OpenProject");
            XmlNsManager.AddNamespace("Ou", "http://www.emed.cc/CodeBuilderStudio/Details/OuterTool");
            XmlNsManager.AddNamespace("Pl", "http://www.emed.cc/CodeBuilderStudio/Details/Plug");
            XmlNsManager.AddNamespace("Sing", "http://www.emed.cc/CodeBuilderStudio/Details/SingleBuilder");
            XmlNsManager.AddNamespace("Ui", "http://www.emed.cc/CodeBuilderStudio/UiBuilder");
        }
        /// <summary>
        /// 内部方法，根据InitXmlNsDomReferences方法得出所有的命名空间映射关系，将文档对象化为DOM
        /// </summary>
        /// <returns>bool</returns>
        private static bool GetDomObjectByXmlns()
        {
            try
            {
                domcollection = new PlugDomCollection();//实例化后才能用
                XmlDocument document = new XmlDocument();
                document.Load(Environment.CurrentDirectory + "\\LoadConfig.xml");//加载构件配置文件LoadConfig.xml
                XmlNode DetailsElement = document.DocumentElement.SelectSingleNode("F:ComeDetails", XmlNsManager);//获取R:ComeRoot
                foreach (XmlElement el in DetailsElement.ChildNodes)
                {
                    PlugDom dom = new PlugDom(el.NamespaceURI, el.Attributes["Assembly"].Value, el.LocalName);
                    domcollection.Add(dom);
                }
                return true;
            }
            catch (Exception err)
            {
                ComeCommonMethod.LogFunction.WritePrivateProfileString(
                    "GetDomObjectByXmlns", err.Source + "->" + err.TargetSite, err.Message, Environment.CurrentDirectory + "\\PlugManagerLog.ini");
                return false;
            }
        }
        /// <summary>
        /// 内部方法，根据Assembly构件宿主程序集名称动态加载内部构件对象
        /// </summary>
        /// <param name="dom">构件文档对象模型PlugDom</param>
        private static object ReflectionDomObject(PlugDom dom)
        {
            try
            {
                Assembly ass = Assembly.LoadFile(Path.Combine(_comeloadpath, dom.Assembly));
                Type[] entrytype = ass.GetTypes();
                foreach (Type type in entrytype)
                {
                    //所有构件基类，查找构件的入口点
                    if (type.GetInterface(string.Format("Main.Interface.{0}", dom.Interface)) != null)
                    {
                        Main.Interface.ComeBaseModule.BaseCome basecome =
                            System.Activator.CreateInstance(type, type.FullName, _comeloadpath, DateTime.Now)
                            as Main.Interface.ComeBaseModule.BaseCome;
                        //注册事件
                        NoteComeLifecycleProcess(basecome);
                        return basecome;
                    }
                }
                throw new Exception("为能实现" + dom.XmlNameSpace + "标识构件，请检查构件配置文件");
            }
            catch (Exception err)
            {

                ComeCommonMethod.LogFunction.WritePrivateProfileString(
                    "GetDomObjectByXmlns", err.Source + "->" + err.TargetSite, err.Message, Environment.CurrentDirectory + "\\PlugManagerLog.ini");
                return null;
            }
        }
        /// <summary>
        /// 记录所有构件共有的生命周期事件数据
        /// </summary>
        private static void NoteComeLifecycleProcess(Main.Interface.ComeBaseModule.BaseCome basecome)
        {
            basecome.ComeStartGoodsEvent += basecome_ComeStartGoodsEvent;
            basecome.ComeExitGoodsEvent += basecome_ComeExitGoodsEvent;
            basecome.ComeExceptionEvent += basecome_ComeExceptionEvent;
        }

        #region 订阅所有构件的生命周期事件
        /// <summary>
        /// 记录构件退出时的事件信息
        /// </summary>
        /// <param name="args">Main.Interface.EventArgs.ExitRouterEventArgs</param>
        private static void basecome_ComeExitGoodsEvent(Main.Interface.ComeBaseModule.ComeRestException args)
        {
            ComeCommonMethod.LogFunction.WritePrivateProfileString("构件退出消息", args.ComeName, args.Message,
                   Environment.CurrentDirectory + "\\RunMainInterface.ini");
        }
        /// <summary>
        /// 记录构件启动时的事件信息
        /// </summary>
        /// <param name="args">Main.Interface.EventArgs.LoadRouterEventArgs</param>
        private static void basecome_ComeStartGoodsEvent(Main.Interface.ComeBaseModule.ComeRestException args)
        {
            ComeCommonMethod.LogFunction.WritePrivateProfileString("构件启动事件", args.ComeName, args.Message,
                  Environment.CurrentDirectory + "\\EndMainInterface.ini");
        }
        /// <summary>
        /// 构件内部处理出现异常
        /// </summary>
        /// <param name="args">异常类</param>
        static void basecome_ComeExceptionEvent(Main.Interface.ComeBaseModule.ComeRestException args)
        {
            ComeCommonMethod.LogFunction.WritePrivateProfileString("构件内部处理错误", args.ComeName, args.Message,
                 Environment.CurrentDirectory + "\\EndMainInterface.ini");
        }
        #endregion
        #endregion
    }
    #endregion
}
