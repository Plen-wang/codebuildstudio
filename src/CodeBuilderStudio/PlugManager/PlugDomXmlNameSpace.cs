/*
 *author:南京.王清培
 *coding time:2011.5.29
 *copyright:快捷速递
 *function:构件文档对象模型的XML命名空间，用来区分不同的构件系统区域
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace PlugManager
{
    /// <summary>
    /// 构件系统命名空间，在指定的构件命名空间下不能存在一个以上构件，在配置文件中的Assembly属性只能出现一次
    /// </summary>
    public static class PlugDomXmlNameSpace
    {
        /// <summary>
        /// 顶级命名空间，用来标识构件配置文件的根节点
        /// </summary>
        public static string Root = "http://www.emed.cc/CodeBuilderStudio";
        /// <summary>
        /// 构件明细命名空间，用来标识所有构件的配置开始
        /// </summary>
        public static string ComeDetails = "http://www.emed.cc/CodeBuilderStudio/Details";
        /// <summary>
        /// About，关于构件的XmlDom命名空间
        /// </summary>
        public static string About = "http://www.emed.cc/CodeBuilderStudio/Details/About";
        /// <summary>
        /// Close，关闭构件的XmlDom命名空间
        /// </summary>
        public static string Close = "http://www.emed.cc/CodeBuilderStudio/Details/Close";
        /// <summary>
        /// ComplexBuilder，复合生成构件XmlDom命名空间
        /// </summary>
        public static string ComplexBuilder = "http://www.emed.cc/CodeBuilderStudio/Details/ComplexBuilder";
        /// <summary>
        /// DataSourceOpen，打开数据源构件XmlDom命名空间
        /// </summary>
        public static string DataSourceOpen = "http://www.emed.cc/CodeBuilderStudio/Details/DataSourceOpen";
        /// <summary>
        /// Exit，退出构件XmlDom命名空间
        /// </summary>
        public static string Exit = "http://www.emed.cc/CodeBuilderStudio/Details/Exit";
        /// <summary>
        /// Helper，帮助构件XmlDom命名空间
        /// </summary>
        public static string Helper = "http://www.emed.cc/CodeBuilderStudio/Details/Helper";
        /// <summary>
        /// NewProject，新建项目构件XmlDom命名空间
        /// </summary>
        public static string NewProject = "http://www.emed.cc/CodeBuilderStudio/Details/NewProject";
        /// <summary>
        /// OpenProject，打开项目构件XmlDom命名空间
        /// </summary>
        public static string OpenProject = "http://www.emed.cc/CodeBuilderStudio/Details/OpenProject";
        /// <summary>
        /// OuterTool，外部工具构件XmlDom命名空间
        /// </summary>
        public static string OuterTool = "http://www.emed.cc/CodeBuilderStudio/Details/OuterTool";
        /// <summary>
        /// Plug，插件构件XmlDom命名空间
        /// </summary>
        public static string Plug = "http://www.emed.cc/CodeBuilderStudio/Details/Plug";
        /// <summary>
        /// SingleBuilder，单件生成构件XmlDom命名空间
        /// </summary>
        public static string SingleBuilder = "http://www.emed.cc/CodeBuilderStudio/Details/SingleBuilder";
        /// <summary>
        /// UiBuilder,界面生成构件XmlDom命名空间
        /// </summary>
        public static string UiBuilder = "http://www.emed.cc/CodeBuilderStudio/UiBuilder";
        /// <summary>
        /// BuilderProcedure,生成存储过程构建
        /// </summary>
        public static string BuilderProcedure = "http://www.emed.cc/CodeBuilderStudio/BuilderProcedure";
    }
}
