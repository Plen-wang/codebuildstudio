using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ComeCommonMethod
{
    public static class XmlFunction
    {
        /// <summary>
        /// 设置指定XML节点属性的Value属性的值
        /// </summary>
        /// <param name="xmlpath">XML的路径</param>
        /// <param name="keypath">节点的XMLPATH路径</param>
        /// <param name="attributename">要设置的属性名称</param>
        /// <param name="value">要设置的值</param>
        public static void SetNodeValueByAttribute(string xmlpath, string keypath, string attributename, string value)
        {
            XmlDocument document = new XmlDocument();
            document.Load(xmlpath);
            XmlNode parentnode = document.DocumentElement;
            XmlNode keynode = parentnode.SelectSingleNode(keypath);
            keynode.Attributes[attributename].Value = value;
            document.Save(xmlpath);
        }
        /// <summary>
        /// 获取指定XML节点的所有子节点
        /// </summary>
        /// <param name="xmlpath">XML路径</param>
        /// <param name="keypath">节点的XMLPATH路径</param>
        /// <returns>XmlNodeList节点集合</returns>
        public static XmlNodeList GetElementList(string xmlpath, string keypath)
        {
            List<XmlElement> result = new List<XmlElement>();
            XmlDocument document = new XmlDocument();
            document.Load(xmlpath);
            XmlNode parentnode = document.DocumentElement;
            XmlNodeList keynode = parentnode.SelectNodes(keypath);
            return keynode;
        }
    }
}
