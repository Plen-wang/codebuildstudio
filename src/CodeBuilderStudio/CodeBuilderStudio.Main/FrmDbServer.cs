using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Main.Interface;
using Main.Interface.ComeBaseModule;

namespace CodeBuilderStudio.Main
{
    /// <summary>
    /// 数据源管理器构件入口，用来打开关于数据库一些操作的构件
    /// </summary>
    public partial class FrmDbServer : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        #region 窗体变量及构造函数
        private static FrmDbServer _thisfrm;
        public static FrmDbServer _Currentfrm
        {
            get
            {
                if (_thisfrm == null)
                    _thisfrm = new FrmDbServer();
                return _thisfrm;
            }
        }
        /// <summary>
        /// 默认构造函数
        /// </summary>
        private FrmDbServer()
        {
            InitializeComponent();
            this.Shown += new EventHandler(FrmDbServer_Shown);
            _thisfrm = this;

            #region 构件PlugKernelManager核心管理器中心事件，这部分事件是PlugKernelManager在处理过程中的事件；
            PlugManager.PlugKernelManager.ComeExitEvent += new PlugManager.ComeExitHander(PlugKernelManager_ComeExitEvent);
            PlugManager.PlugKernelManager.ComeLoadEvent += new PlugManager.ComeLoadHander(PlugKernelManager_ComeLoadEvent);
            #endregion

            #region 窗体事件链WinFrmLifecycleEvent，维持所有窗体的联动性；
            WinFrmLifecycleEvent.MainViewFrmCloseEvent += new EventHandler(WinFrmLifecycleEvent_MainViewFrmCloseEvent);
            WinFrmLifecycleEvent.CloseGlobalEvent += new EventHandler(WinFrmLifecycleEvent_CloseGlobalEvent);
            WinFrmLifecycleEvent.OnMainOperationSingleBuilderComeEvent += new MainOperationSingleBuilderComeHandler(WinFrmLifecycleEvent_OnMainOperationSingleBuilderComeEvent);
            #endregion
        }

        void FrmDbServer_Shown(object sender, EventArgs e)
        {
            this.Focus();
        }

        private SingleBuilder WinFrmLifecycleEvent_OnMainOperationSingleBuilderComeEvent()
        {
            if (_currenttblist != null)
            {
                if (_currenttblist.Count > 0)
                {
                    if (singlebasecome == null)
                    {
                        singlebasecome = NewBaseCome("http://www.emed.cc/CodeBuilderStudio/Details/SingleBuilder");//获取SingleBuilder.Come.dll构件实例
                        (singlebasecome as SingleBuilder).BuilderSourceType = (basecome as DataSourceOpen).CurrentSourceType;
                        (singlebasecome as SingleBuilder).CurrentDataTableSource = _currenttblist;
                        (singlebasecome as SingleBuilder).CurrentDataSource = (basecome as DataSourceOpen);//设置数据源DataSourceOpen对象
                        return singlebasecome as SingleBuilder;
                    }
                    else
                    {
                        (singlebasecome as SingleBuilder).BuilderSourceType = (basecome as DataSourceOpen).CurrentSourceType;
                        (singlebasecome as SingleBuilder).CurrentDataTableSource = _currenttblist;
                        (singlebasecome as SingleBuilder).CurrentDataSource = (basecome as DataSourceOpen);//设置数据源DataSourceOpen对象
                        return singlebasecome as SingleBuilder;
                    }
                }
                return null;
            }
            else
                return null;
        }

        private void WinFrmLifecycleEvent_CloseGlobalEvent(object sender, EventArgs e)
        {
            Tools_end_Click(null, null);
        }

        private void WinFrmLifecycleEvent_MainViewFrmCloseEvent(object sender, EventArgs e)
        {
            isviewfrm = false;
        }

        #region 构件PlugKernelManager管理器事件方法，可以在构件的两个生命周期间记录点东西；
        /// <summary>
        /// 构件管理器开始加载本功能的入口构件
        /// </summary>
        /// <param name="comename">构件的名称</param>
        public void PlugKernelManager_ComeLoadEvent(string comename) { }
        /// <summary>
        /// 构件管理器开始退出本功能的入口构件
        /// </summary>
        /// <param name="comename">构件的名称</param>
        private void PlugKernelManager_ComeExitEvent(string comename) { }
        #endregion

        #endregion

        #region 工具栏事件
        /// <summary>
        /// DataSourceOpen插件接口，上下文使用；
        /// </summary>
        BaseCome basecome;
        /// <summary>
        /// 打开SqlServer数据源
        /// </summary>
        private void Tools_Sqlmenu_Click(object sender, EventArgs e)
        {
            basecome = NewBaseCome();
            (basecome as DataSourceOpen).PassDataEvent += new PassDataHandler(FrmDbServer_PassDataEvent);
            basecome.StartCome();
        }
        private void Tools_oraclemuen_Click(object sender, EventArgs e)
        {
            basecome = NewBaseCome();
            (basecome as DataSourceOpen).PassDataEvent += new PassDataHandler(FrmDbServer_PassDataEvent);
            (basecome as DataSourceOpen).CurrentSourceType = DataSourceType.Oracle;//ORACLE数据源
            basecome.StartCome();
        }
        private void FrmDbServer_PassDataEvent(List<string> param, params string[] par)
        {
            if (par.Length > 0)
                if (!IsOpenSource(par[0]))
                    BindTreeView(param, par);
            _currenttblist = param;
        }
        public List<string> _currenttblist { get; set; }
        /// <summary>
        /// 刷新数据源
        /// </summary>
        private void Tools_ref_Click(object sender, EventArgs e)
        {
            if (TV_tblist.Nodes.Count <= 0)
                return;
            object[] list = GetSourceList();
            (basecome as DataSourceOpen).RefurbishSourceEvent += new RefurbishSourceHanlder(FrmDbServer_RefurbishSourceEvent);
            (basecome as DataSourceOpen).RefurbishSource((list[0] as List<string>), (list[1] as List<string>));
        }
        private void FrmDbServer_RefurbishSourceEvent(Dictionary<string, List<string>> sourcetable)
        {
            foreach (TreeNode node in TV_tblist.Nodes)
            {
                if (node.Tag == null)
                    return;
                if (node.Tag.ToString() == "1")
                {
                    BindTreeView(sourcetable[node.Text], node.Text, node.Nodes[0].Text);
                    node.Remove();
                }
            }
        }
        /// <summary>
        /// 断开数据源
        /// </summary>
        private void Tools_end_Click(object sender, EventArgs e)
        {
            TV_tblist.Nodes.Clear();
            _currenttblist.Clear();
        }
        /// <summary>
        /// 检索目录树中的制定表名称的节点
        /// </summary>
        private void Tools_link_Click(object sender, EventArgs e)
        {
            if (TV_tblist.Nodes.Count <= 0)
                return;
            (basecome as DataSourceOpen).LookUpTableNode(TV_tblist, global::System.Windows.Forms.Control.MousePosition);
        }
        /// <summary>
        /// 是否已经打开过视图窗口
        /// </summary>
        bool isviewfrm = false;
        /// <summary>
        /// 查看表视图
        /// </summary>
        private void Tools_viewtable_Click(object sender, EventArgs e)
        {
            if (TV_tblist.SelectedNode == null || TV_tblist.SelectedNode.Tag.ToString() != "3")
                return;
            if (isviewfrm)
            {
                (basecome as DataSourceOpen).ViewTableChildControlEvent += new ViewTableChildControlHandler(FrmDbServer_ViewTableChildControlEvent);
                (basecome as DataSourceOpen).ViewTable(TV_tblist.SelectedNode.Parent.Parent.Text, TV_tblist.SelectedNode.Text, true);
                return;
            }
            (basecome as DataSourceOpen).ViewTableEvent += new ViewTableHandler(FrmDbServer_ViewTableEvent);
            (basecome as DataSourceOpen).ViewTable(TV_tblist.SelectedNode.Parent.Parent.Text, TV_tblist.SelectedNode.Text);
            (basecome as DataSourceOpen).OpenSingleBuilderViewEvent += new OpenSingleBuilderView(FrmDbServer_OpenSingleBuilderViewEvent);
            isviewfrm = true;
        }

        void FrmDbServer_ViewTableChildControlEvent(UserControl control, System.Windows.Forms.Control parent)
        {
            WinFrmLifecycleEvent.OnViewTableControlEvent(control, parent);
        }
        /// <summary>
        /// 单件生成代码构件实例
        /// </summary>
        BaseCome singlebasecome;
        private void FrmDbServer_OpenSingleBuilderViewEvent(DataTable dt)
        {
            if (singlebasecome == null)
                singlebasecome = NewBaseCome("http://www.emed.cc/CodeBuilderStudio/Details/SingleBuilder");//获取SingleBuilder.Come.dll构件实例
            (singlebasecome as SingleBuilder).BuilderSourceType = (basecome as DataSourceOpen).CurrentSourceType;
            (singlebasecome as SingleBuilder).BrowserSaveDirectoryFrontEvent +=
                new BrowserSaveDirectoryHandler<BrowserActivateType, object>(FrmDbServer_BrowserSaveDirectoryFrontEvent);
            (singlebasecome as SingleBuilder).OpenSingleBuilderView(dt);
        }

        void FrmDbServer_BrowserSaveDirectoryFrontEvent(object u)
        {
            FolderBrowserDialog browserdirectory = new FolderBrowserDialog();
            if (browserdirectory.ShowDialog() == DialogResult.OK)
            {
                (singlebasecome as SingleBuilder).OnBrowserSaveDirectoryCallBackEvent(browserdirectory.SelectedPath);
            }
        }
        private void FrmDbServer_ViewTableEvent(WeifenLuo.WinFormsUI.Docking.DockContent DockContent)
        {
            WinFrmLifecycleEvent.OnViewTableFrmEvent(DockContent);
        }

        #endregion

        #region 公共方法
        /// <summary>
        /// 统一获取构件基类
        /// </summary>
        /// <returns>BaseCome对象</returns>
        private BaseCome NewBaseCome()
        {
            return (PlugManager.PlugKernelManager.MainEventProcess("http://www.emed.cc/CodeBuilderStudio/Details/DataSourceOpen") as BaseCome);
        }
        /// <summary>
        /// 重载NewBaseCome方法，根据构件的XML命名空间来获取构件实例
        /// </summary>
        /// <param name="comexml">XML命名空间字符串</param>
        /// <returns></returns>
        private BaseCome NewBaseCome(string comexml)
        {
            return (PlugManager.PlugKernelManager.MainEventProcess(comexml) as BaseCome);
        }
        /// <summary>
        /// 绑定数据源Table数据项
        /// </summary>
        /// <param name="tblist">Table集合</param>
        private void BindTreeView(List<string> tblist, params string[] sourceinfo)
        {
            tblist.Sort();
            TreeNode servernode = new TreeNode(sourceinfo[0]);//服务器节点
            servernode.ImageIndex = 2;
            servernode.SelectedImageIndex = 2;
            servernode.Tag = "1";//标识该节点是服务器节点

            TreeNode databasenode = new TreeNode(sourceinfo[1]);//数据库节点
            databasenode.ImageIndex = 0;
            databasenode.SelectedImageIndex = 0;
            databasenode.Tag = "2";//标识节点为数据库节点

            foreach (string str in tblist)
            {
                TreeNode tablenode = new TreeNode(str);
                tablenode.ImageIndex = 1;
                tablenode.SelectedImageIndex = 1;
                tablenode.Tag = "3";//标识节点为表节点
                databasenode.Nodes.Add(tablenode);
            }
            servernode.Nodes.Add(databasenode);
            TV_tblist.Nodes.Add(servernode);

            TV_tblist.ExpandAll();
        }
        /// <summary>
        /// 获取数据源列表，一个数据源对应一个数据库
        /// </summary>
        /// <returns>数据源集合</returns>
        private object[] GetSourceList()
        {
            List<string> resultservernode = new List<string>();
            List<string> resultdatabase = new List<string>();
            foreach (TreeNode node in TV_tblist.Nodes)
            {
                if (node.Tag != null)
                {
                    if (node.Tag.ToString() == "1")
                    {
                        resultservernode.Add(node.Text);
                        foreach (TreeNode cnode in node.Nodes)
                        {
                            if (cnode != null)
                            {
                                if (cnode.Tag.ToString() == "2")
                                {
                                    resultdatabase.Add(cnode.Text);
                                }
                            }
                        }
                    }
                }
            }
            return new object[] { resultservernode, resultdatabase };
        }
        /// <summary>
        /// 是否已经打开相同的数据源
        /// </summary>
        /// <param name="source">数据源名称</param>
        /// <returns>是否已经添加，true已经添加，false未添加</returns>
        private bool IsOpenSource(string source)
        {
            foreach (TreeNode node in TV_tblist.Nodes)
            {
                if (node.Text == source)
                {
                    MessageBox.Show(this, "已添加了相同节点的数据源，如果重新添加则必须断开，或者采用刷新的方式!", "信息提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        #endregion

        private void TV_tblist_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Tools_viewtable_Click(null, null);
        }



    }
}
