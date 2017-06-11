/*
 *author:南京.王清培
 *coding time:2011.5.29
 *copyright:快捷速递
 *function:构件文档对象模型对象，将构件的配置文件定义为DOM对象；
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace PlugManager
{
    /// <summary>
    /// 构件对象模型，后期可能存在多个属性
    /// </summary>
    public class PlugDom
    {
        /// <summary>
        /// 构件所对应的XML命名空间
        /// </summary>
        private string _xmlnamespace = string.Empty;
        /// <summary>
        /// 构件所在的程序集名称
        /// </summary>
        private string _assembly = string.Empty;
        /// <summary>
        /// 构建实现接口
        /// </summary>
        private string _interface = string.Empty;
        /// <summary>
        /// 获取构件程序集名称
        /// </summary>
        public string Assembly
        {
            get { return _assembly; }
        }
        /// <summary>
        /// 获取构件命名空间
        /// </summary>
        public string XmlNameSpace
        {
            get { return _xmlnamespace; }
        }
        /// <summary>
        /// 构建实现接口
        /// </summary>
        public string Interface
        {
            get { return _interface; }
        }
        /// <summary>
        /// 重载构造函数，用构件的动态连接库名称、构件的XML命名空间初始化构件对象
        /// </summary>
        /// <param name="assemblyname">构件动态连接库名称</param>
        /// <param name="xmlname">构件XML命名空间</param>
        /// <param name="inter">构件接口</param>
        public PlugDom(string assemblyname, string xmlname, string inter)
        {
            _xmlnamespace = assemblyname;
            _assembly = xmlname;
            _interface = inter;
        }
    }
}
