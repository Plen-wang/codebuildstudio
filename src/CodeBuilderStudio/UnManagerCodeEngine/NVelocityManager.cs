/*
 *author:南京.王清培
 *coding time:2011.9.8
 *copyright:快捷速递
 *function:VM模板引擎的管理
 */
using System;
using System.Collections.Generic;
using System.Text;

using NVelocity;
using NVelocity.App;
using NVelocity.Context;
using NVelocity.Exception;
using NVelocity.Runtime;
using NVelocity.Tool;
using NVelocity.Util;
using Commons.Collections;

namespace UnManagerCodeEngine
{
    /// <summary>
    /// 该类负责管理模板引擎(该模板引擎支持所有托管对象语法特性)
    /// </summary>
    public class NVelocityManager
    {
        /// <summary>
        /// 实例化模板引擎(该对象是模板引擎核心对象负责前台页面中的VTL标记与后台C#对象的绑定生成)
        /// </summary>
        private static VelocityEngine engine;
        /// <summary>
        /// 模板引擎设置对象(该对象是模板引擎设置对象负责设置模板引擎的生成属性如：编码UTF-8)
        /// </summary>
        private static ExtendedProperties property = new ExtendedProperties();
        /// <summary>
        /// 封送设置模板引擎新实例对象的属性时的时间和地址
        /// </summary>
        /// <param name="ondatetime">触发时间</param>
        /// <param name="onpath">设置的模板地址</param>
        public delegate void OnSetNVelocityPropertyHander(DateTime ondatetime, string onpath);
        /// <summary>
        /// 设置新实例的模板属性时触发
        /// </summary>
        public static event OnSetNVelocityPropertyHander SetNVelociryProperty;
        /// <summary>
        /// 获取模板引擎对象VelocityEngIne
        /// </summary>
        public static VelocityEngine GetEngIne
        {
            get { return engine; }
        }
        /// <summary>
        /// 静态构造函数，初始化静态模板属性对象
        /// </summary>
        static NVelocityManager()
        {
            property.AddProperty(RuntimeConstants.INPUT_ENCODING, "UTF-8");//模板读入编码格式
            property.AddProperty(RuntimeConstants.OUTPUT_ENCODING, "UTF-8");//模板输入编码格式
            property.AddProperty(RuntimeConstants.RESOURCE_LOADER, "file");//模板加载方式
            property.AddProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, "");//模板加载的目录
        }
        /// <summary>
        /// 设置模板引擎(因为模板引擎读写文件目录不同所以在每次生成模板前要设置模板读写的路径)
        /// </summary>
        /// <param name="path">模板引擎将要读取的模板的更目录</param>
        public static void SetProperty(string path)
        {
            engine = new VelocityEngine();//必须每次都要实例化新的对象，因为模板地址属性没办法重新设置
            property.SetProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, path);
            engine.Init(property);//初始化模板引擎
            if (engine.GetProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH) != null)
            {
                string param = engine.GetProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH).ToString();
                if (SetNVelociryProperty != null)
                    SetNVelociryProperty(new DateTime(), param);//发送事件参数，至少有一个封送地址存在，否则报错
            }
        }
    }
}
