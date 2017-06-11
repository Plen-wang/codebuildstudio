/*
 *author:南京.王清培
 *coding time:2011.5.28
 *function:将整个应用程序以公开接口的方式向外传递，本接口是公开实现数据源时要实现的，让构件能无限极的向下延伸；
 *copyright:快捷速递
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace Main.Interface
{
    /// <summary>
    /// 数据传递委托
    /// </summary>
    /// <param name="param">回传数据</param>
    /// <param name="par">参数列表</param>
    public delegate void PassDataHandler(List<string> param, params string[] par);
    /// <summary>
    /// 数据源刷新委托
    /// </summary>
    /// <param name="sourcetable">数据源表集合</param>
    public delegate void RefurbishSourceHanlder(Dictionary<string, List<string>> sourcetable);
    /// <summary>
    /// 查看表列信息委托
    /// </summary>
    /// <param name="DockContent">视图容器</param>
    public delegate void ViewTableHandler(WeifenLuo.WinFormsUI.Docking.DockContent DockContent);
    /// <summary>
    /// 查看表列表信息委托，显示单独的子控件
    /// </summary>
    /// <param name="control">要添加的控件实例</param>
    /// <param name="parent">控件父容器</param>
    public delegate void ViewTableChildControlHandler(UserControl control, Control parent);
    /// <summary>
    /// 打开单件生成视图
    /// </summary>
    /// <param name="dt">数据表</param>
    public delegate void OpenSingleBuilderView(DataTable dt);
    /// <summary>
    /// 打开的数据源类型
    /// </summary>
    public enum DataSourceType
    {
        MicrosfotSqlServer,
        Oracle,
        Oledb,
        MySql
    }
    /// <summary>
    /// 打开数据源构件接口，用来公开主程序要实现的打开数据源功能接口
    /// </summary>
    public interface DataSourceOpen
    {
        /// <summary>
        /// 成功打开数据源，通过该事件可以获取到指定数据源中的所有表名称集合
        /// </summary>
        event PassDataHandler PassDataEvent;
        /// <summary>
        /// 刷新数据源事件，当成功连接数据源之后并返回刷新后的数据集合时触发
        /// </summary>
        event RefurbishSourceHanlder RefurbishSourceEvent;
        /// <summary>
        /// 表视图查看事件
        /// </summary>
        event ViewTableHandler ViewTableEvent;
        /// <summary>
        /// 表视图子控件查看事件
        /// </summary>
        event ViewTableChildControlHandler ViewTableChildControlEvent;
        /// <summary>
        /// 打开单件生成代码视图
        /// </summary>
        event OpenSingleBuilderView OpenSingleBuilderViewEvent;
        /// <summary>
        /// 打开多单件生成代码视图
        /// </summary>
        event OpenSingleBuilderView OpenMuilterSingleBuilderEventEvent;
        /// <summary>
        /// 获取多单件代码生成视图数据源
        /// </summary>
        /// <param name="tbname">要查询详细信息的表名称</param>
        /// <param name="dt">数据源引用</param>
        void GetMuilterSingleDataSource(string tbname, out DataTable dt);
        /// <summary>
        /// 获取存储过程数据
        /// </summary>
        /// <param name="pname"></param>
        /// <param name="dt"></param>
        void GetProcedure(string pname, out object dt);
        /// <summary>
        /// 获取或设置数据源连接字符串
        /// </summary>
        StringBuilder ConnectionString { get; set; }
        /// <summary>
        /// 获取打开的数据源类型
        /// </summary>
        DataSourceType CurrentSourceType { get; set; }
        /// <summary>
        /// 刷新数据源
        /// </summary>
        /// <param name="source">数据源列表</param>
        /// <param name="database">数据库列表</param>
        void RefurbishSource(List<string> source, List<string> database);
        /// <summary>
        /// 打开数据源，如果返回true，说明数据源打开成功，false则失败；
        /// </summary>
        /// <param name="connstr">数据源连接字符串</param>
        /// <param name="dbname">要打开的表名称</param>
        bool Open(string connstr, string dbname);
        /// <summary>
        /// 检索目录树中的制定名称的节点
        /// </summary>
        /// <param name="tv">节点容器控件TreeView</param>
        /// <param name="frmlocation">检索窗口的停靠点</param>
        void LookUpTableNode(System.Windows.Forms.TreeView tv, Point frmlocation);
        /// <summary>
        /// 查看表视图
        /// </summary>
        /// <param name="source">数据源</param>
        /// <param name="tablename">表名称</param>
        void ViewTable(string source, string tablename);
        /// <summary>
        /// 查看表视图，重载ViewTable方法，返回单独子控件
        /// </summary>
        /// <param name="source">数据源</param>
        /// <param name="tablename">表名称</param>
        /// <param name="isview">是否已经查看过</param>
        void ViewTable(string source, string tablename, bool isview);

    }
}
