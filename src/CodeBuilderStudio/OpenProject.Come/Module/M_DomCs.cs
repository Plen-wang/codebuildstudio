/*
 *author:南京.王清培
 *coding time:2011.7.11
 *copyright:快捷速递
 *function:打开解决方案中的所有文件时，该类对应着cs文件；DOM思想
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace OpenProject.Come.Module
{
    /// <summary>
    /// 源文件的类型
    /// </summary>
    public enum CsType
    {
        /// <summary>
        /// Winform界面设计文件
        /// </summary>
        winform,
        /// <summary>
        /// 设计器类文件
        /// </summary>
        design,
        /// <summary>
        /// Asp.net界面设计文件
        /// </summary>
        aspx,
        /// <summary>
        /// 程序集资源设计文件
        /// </summary>
        resource,
        /// <summary>
        /// 普通的*.cs文件
        /// </summary>
        Cs,
        /// <summary>
        /// 图片文件
        /// </summary>
        img,
        /// <summary>
        /// HTML页面
        /// </summary>
        html,
        /// <summary>
        /// 配置文件
        /// </summary>
        config,
        /// <summary>
        /// js文件
        /// </summary>
        js,
        /// <summary>
        /// 样式表
        /// </summary>
        css,
        /// <summary>
        /// Webservice,disco发现文件
        /// </summary>
        disco,
        /// <summary>
        /// WebService,wsdl定义语言
        /// </summary>
        wsdl,
        /// <summary>
        /// Webservice,map地址文件
        /// </summary>
        map,
        /// <summary>
        /// 程序集设置文件
        /// </summary>
        settings,
        /// <summary>
        /// 陌生类型
        /// </summary>
        defaults
    }
    /// <summary>
    /// CS文件对象
    /// </summary>
    public class M_DomCs : M_DomBase
    {
        /// <summary>
        /// 文件类型
        /// </summary>
        public CsType IsType = OpenProject.Come.Module.CsType.defaults;
        /// <summary>
        /// 如果当前源文件对象属于设计器类型的，则可能存在Design.cs和Resource.cs文件
        /// </summary>
        public List<M_DomCs> _cslist = new List<M_DomCs>();
    }
}
