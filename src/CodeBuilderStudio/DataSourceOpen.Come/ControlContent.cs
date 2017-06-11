/*
 *author:南京.王清培
 *coding time:2011.5.28
 *copyright:快捷速递
 *function:开发数据源构件实现，DataSourceOpen.Come项目；
 */
using System;
using System.Collections.Generic;
using System.Text;
using Main.Interface.ComeBaseModule;
using System.Data;

namespace DataSourceOpen.Come
{
    /// <summary>
    /// 继承构件基类，没有完全实现构件，继续向下传递实现；
    /// </summary>
    [Main.Interface.Attribute.WheTherNextTransfer(IfNextTransfer = true, ChildAssembly = "CodeBuilderStudio.DataSourceOpen.Childe1",
        ChildInterface = "DataSourceOpen.Interface.NextComeInterface")]
    public class ControlContent : BaseCome, Main.Interface.DataSourceOpen
    {
        public ControlContent() { }
        /// <summary>
        /// 重载构造函数，初始化构件的基本属性
        /// </summary>
        /// <param name="comename">构件名称</param>
        /// <param name="loadpath">构件的加载路径</param>
        /// <param name="time">装载时间</param>
        public ControlContent(string comename, string loadpath, DateTime time) : base(comename, loadpath, time) { }
        /// <summary>
        /// 启动构件，进行生命使用
        /// </summary>
        public override void StartCome()
        {
            try
            {
                if (CurrentSourceType == Main.Interface.DataSourceType.Oracle)
                {
                    OracleDataSource.FrmLogin login = new OracleDataSource.FrmLogin(this);
                    login.ShowDialog();
                }
                else if (CurrentSourceType == Main.Interface.DataSourceType.MicrosfotSqlServer)
                {
                    FrmLoginDataSource logindb = new FrmLoginDataSource(this);
                    logindb.ShowDialog();
                    CurrentSourceType = Main.Interface.DataSourceType.MicrosfotSqlServer;
                }
            }
            catch (System.Exception err)
            {
                Main.Interface.ComeBaseModule.ComeRestException exception = new ComeRestException(err.Message, "DataSourceOpen");
                this.OnComeExceptionEvent(exception);
            }
        }
        /// <summary>
        /// 释放构件占用的托管、非托管资源
        /// </summary>
        public override void Dispose() { }

        #region DataSourceOpen 成员

        private Main.Interface.PassDataHandler _passdataeventhandler;
        public event Main.Interface.PassDataHandler PassDataEvent
        {
            add
            {
                if (_passdataeventhandler == null)
                    _passdataeventhandler += value;
            }
            remove
            {
                if (_passdataeventhandler != null)
                    _passdataeventhandler -= value;

            }
        }
        private Main.Interface.RefurbishSourceHanlder _refurbishsourceeventhandler;
        public event Main.Interface.RefurbishSourceHanlder RefurbishSourceEvent
        {
            add
            {
                if (_refurbishsourceeventhandler == null)
                    _refurbishsourceeventhandler += value;
            }
            remove
            {
                if (_refurbishsourceeventhandler != null)
                    _refurbishsourceeventhandler -= value;
            }
        }

        private Main.Interface.OpenSingleBuilderView _opensinglebuildervieweventhandler;
        public event Main.Interface.OpenSingleBuilderView OpenSingleBuilderViewEvent
        {
            add
            {
                if (_opensinglebuildervieweventhandler == null)
                    _opensinglebuildervieweventhandler += value;
            }
            remove
            {
                if (_opensinglebuildervieweventhandler != null)
                    _opensinglebuildervieweventhandler -= value;

            }
        }
        public void OnOpenSingleBuilderViewEvent(System.Data.DataTable dt)
        {
            _opensinglebuildervieweventhandler(dt);
        }

        public void OnPassDataEvent(List<string> data, params string[] par)
        {
            _passdataeventhandler(data, par);
        }
        public void OnRefurbishSourceEvent(Dictionary<string, List<string>> sourcelist)
        {
            _refurbishsourceeventhandler(sourcelist);
        }

        public void RefurbishSource(List<string> source, List<string> database)
        {
            Dictionary<string, List<string>> resultlist = new Dictionary<string, List<string>>();
            for (int i = 0; i < source.Count; i++)
            {
                //获取所有表名称集合
                List<string> tablelist = new List<string>();
                if (CurrentSourceType == Main.Interface.DataSourceType.MicrosfotSqlServer)
                    tablelist = Command.DataSourceCommand.GetTableColl(source[0]);//SqlServer数据源
                else if (CurrentSourceType == Main.Interface.DataSourceType.Oracle)
                    tablelist = Command.OracleCommand.DataSourceCommand.GetTableColl(source[0]);//Oracle数据源
                if (tablelist.Count > 0)
                    resultlist.Add(source[0], tablelist);
                //获取所有视图名称集合
                List<string> viewlist = Command.DataSourceCommand.GetViewList(source[0]);
                if (tablelist.Count > 0)
                    resultlist.Add(source[0], viewlist);
            }
            if (resultlist.Count > 0)
                OnRefurbishSourceEvent(resultlist);
        }
        public StringBuilder ConnectionString { get; set; }
        public Main.Interface.DataSourceType CurrentSourceType { get; set; }
        public bool Open(string connstr, string dbname)
        {
            return true;
        }
        public void LookUpTableNode(System.Windows.Forms.TreeView tv, System.Drawing.Point frmlocation)
        {
            new FrmLookUpTable(tv, frmlocation).Show();
        }

        public event Main.Interface.ViewTableHandler ViewTableEvent;
        FrmTableViewContainer frmview;
        public void ViewTable(string source, string tablename)
        {
            frmview = new FrmTableViewContainer();
            ControlTableView tview = new ControlTableView(tablename, source, this);
            tview.Disposed += new EventHandler(tview_Disposed);
            tview.Location = new System.Drawing.Point(10, 30);
            tview.Location = new System.Drawing.Point(0, 0);
            frmview.panel1.Controls.Add(tview);
            frmview.ChildActivatedView.Add(tview);
            ViewTableEvent(frmview);
        }

        void tview_Disposed(object sender, EventArgs e)
        {
            frmview.ChildActivatedView.Remove(sender as ControlTableView);
        }

        public event Main.Interface.ViewTableChildControlHandler ViewTableChildControlEvent;

        public void ViewTable(string source, string tablename, bool isview)
        {
            ControlTableView view = new ControlTableView(tablename, source, this);
            view.Disposed += tview_Disposed;
            frmview.ChildActivatedView.Add(view);
            ViewTableChildControlEvent(view, (frmview as FrmTableViewContainer).panel1);
        }

        #endregion

        #region DataSourceOpen 成员
        public event Main.Interface.OpenSingleBuilderView OpenMuilterSingleBuilderEventEvent;
        public void GetMuilterSingleDataSource(string tbname, out DataTable dt)
        {
            if (CurrentSourceType == Main.Interface.DataSourceType.MicrosfotSqlServer)
                dt = Command.DataSourceCommand.GetTableColumnsInfo(ConnectionString.ToString(), tbname);

            else if (CurrentSourceType == Main.Interface.DataSourceType.Oracle)
                dt = Command.OracleCommand.DataSourceCommand.GetTableColumnsInfo(ConnectionString.ToString(), tbname);

            else
                dt = new DataTable();
        }

        #endregion
        //获取存储过程列表
        public void GetProcedure(string pname, out object dt)
        {
            if (string.IsNullOrEmpty(pname))
            {
                if (CurrentSourceType == Main.Interface.DataSourceType.MicrosfotSqlServer)
                    dt = Command.DataSourceCommand.GetProcedure(ConnectionString.ToString());
                else
                    dt = Command.OracleCommand.DataSourceCommand.GetProcedure(ConnectionString.ToString());
            }
            else
                if (CurrentSourceType == Main.Interface.DataSourceType.MicrosfotSqlServer)
                    dt = Command.DataSourceCommand.GetParameter(ConnectionString.ToString(), pname);
                else
                    dt = Command.OracleCommand.DataSourceCommand.GetParameter(ConnectionString.ToString(), pname);
        }
    }
}
