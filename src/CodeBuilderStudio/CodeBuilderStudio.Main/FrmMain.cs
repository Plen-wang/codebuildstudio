using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CodeBuilderStudio.Control;
using System.Threading;
using Main.Interface.ComeBaseModule;
using Main.Interface;
using System.Runtime.Remoting.Messaging;
using WeifenLuo.WinFormsUI.Docking;

namespace CodeBuilderStudio.Main
{
    public partial class FrmMain : Form
    {

        #region 窗体变量及构造函数
        /// <summary>
        /// 欢迎界面
        /// </summary>
        private FrmFlash flash;
        /// <summary>
        /// 重载构造函数，对欢迎界面设置加载信息
        /// </summary>
        /// <param name="frm">欢迎界面实体 FrmFlash对象</param>
        public FrmMain(FrmFlash frm)
        {
            InitializeComponent();
            //加载布局控件历史数据
            if (File.Exists(Path.Combine(Application.StartupPath, "MainUI.xml")))
            {
                WeifenLuo.WinFormsUI.Docking.DeserializeDockContent dockcontent = new WeifenLuo.WinFormsUI.Docking.DeserializeDockContent(LoadDesignFrm);
                this.dockPanel1.LoadFromXml(Path.Combine(Application.StartupPath, "MainUI.xml"), dockcontent);
            }
            flash = frm;
            this.Load += new EventHandler(FrmMain_Load);
            this.Shown += new EventHandler(FrmMain_Shown);
            this.FormClosing += new FormClosingEventHandler(FrmMain_FormClosing);
            frm.InitInfo = "2.系统正在载入内存请稍等........";
            frm.Refresh();

            #region 订阅全局事件，以实现联动
            WinFrmLifecycleEvent.ViewTableFrmEvent += new ViewTableFrmHandler(WinFrmLifecycleEvent_ViewTableFrmHandler);
            WinFrmLifecycleEvent.ViewTableControlEvent += new ViewTableControlHandler(WinFrmLifecycleEvent_ViewTableControlEvent);
            WinFrmLifecycleEvent.ViewCodeFrmEvent += new ViewTableFrmHandler(WinFrmLifecycleEvent_ViewCodeFrmEvent);
            #endregion
        }

        void WinFrmLifecycleEvent_ViewTableControlEvent(UserControl control, System.Windows.Forms.Control parent)
        {
            Point p = new Point(20, 50);
            for (int i = 0; i < MainContent.Controls.Count; i++) { p.X += 20; p.Y += 20; }//偏移控件的出现位置
            control.Location = p;
            parent.Controls.Add(control);
            MainContent.Activate();
            control.BringToFront();
        }

        void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dockPanel1.SaveAsXml(Path.Combine(Application.StartupPath, "MainUI.xml"));
        }

        void WinFrmLifecycleEvent_ViewCodeFrmEvent(WeifenLuo.WinFormsUI.Docking.DockContent content)
        {
            AddFrmView(content);
        }
        WeifenLuo.WinFormsUI.Docking.DockContent MainContent;
        private void WinFrmLifecycleEvent_ViewTableFrmHandler(WeifenLuo.WinFormsUI.Docking.DockContent content)
        {
            AddFrmView(content);
            content.FormClosed += new FormClosedEventHandler(content_FormClosed);
            MainContent = content;
        }

        void content_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinFrmLifecycleEvent.OnMainViewFrmCloseEvent(sender, e);
        }
        #endregion

        #region 窗体事件
        /// <summary>
        /// 系统加载时，初始化主界面个区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FrmMain_Load(object sender, EventArgs e)
        {
            flash.InitInfo = "3.系统进行构件检查并进行装载请稍等........";
            flash.Refresh();
            PlugManager.PlugKernelManager.ComeLoad();//这段代码后期重写
            flash.InitInfo = "4.加载主界面并显示请稍等........";
            flash.Refresh();
            this.WindowState = FormWindowState.Maximized;
            if (!File.Exists(Path.Combine(Application.StartupPath, "MainUI.xml")))
            {
                LoadDesignFrm();
            }
            flash.Close();
        }
        /// <summary>
        /// 显示界面时，关闭欢迎窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FrmMain_Shown(object sender, EventArgs e)
        {
            flash.Close();
        }
        /// <summary>
        /// 关闭系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
        #endregion

        #region 菜单栏事件
        /// <summary>
        /// 设置界面可以定制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tool_isdesign_Click(object sender, EventArgs e)
        {
            this.dockPanel1.AllowEndUserDocking = true;
            this.dockPanel1.AllowEndUserNestedDocking = true;
            Tool_notdesign.Checked = false;
            Tool_isdesign.Checked = true;
        }
        /// <summary>
        /// 设置界面不可以定制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tool_notdesign_Click(object sender, EventArgs e)
        {
            this.dockPanel1.AllowEndUserDocking = false;
            this.dockPanel1.AllowEndUserNestedDocking = false;
            Tool_isdesign.Checked = false;
            Tool_notdesign.Checked = true;
        }
        BaseCome helpercome;//帮助构件引用
        /// <summary>
        /// 帮助
        /// </summary>
        private void Tools_helper_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 退出
        /// </summary>
        private void Tools_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 构件基类
        /// </summary>
        BaseCome contextbasecome;
        /// <summary>
        /// 打开项目
        /// </summary>
        private void Tools_openobject_Click(object sender, EventArgs e)
        {
            if (contextbasecome == null)
                contextbasecome = NewBaseCome();

            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "解决方案文件,*.sln|*.sln";
            filedialog.Title = "打开.NET解决方案文件";
            filedialog.RestoreDirectory = true;

            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                (contextbasecome as global::Main.Interface.OpenProject).ProjectPath = filedialog.FileName;//设置打开项目构件的打开文件路径
                (contextbasecome as global::Main.Interface.OpenProject).SetProjectNodeEvent += new SetProjectNodeHandler(FrmMain_SetProjectNodeEvent);
                WinFrmLifecycleEvent.OnBrowserProjectEvent((contextbasecome as global::Main.Interface.OpenProject));
            }
        }

        private void FrmMain_SetProjectNodeEvent(string filepath)
        {
            Tools_info.Text = filepath;
            toolStrip1.Refresh();
        }
        private void Tools_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "将关闭所有打开的项目，您确定？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                WinFrmLifecycleEvent.OnCloseGlobalEvent(sender, e);
            }
        }

        //模板编辑
        private delegate void ThempEditCallBackHandle(IAsyncResult result, object parameter);
        global::Main.Interface.ComeBaseModule.BaseCome editcome;
        private void Tools_thempedit_Click(object sender, EventArgs e)
        {
            if (editcome == null)
                editcome = PlugManager.PlugKernelManager.MainEventProcess("http://www.emed.cc/CodeBuilderStudio/Details/ThempEdit") as BaseCome;
            if (editcome == null)
                return;
            (editcome as global::Main.Interface.ThempEdit).OpenEditViewEvent += new ParameterHander<ThempEdit, PlugEventArgs>(FrmMain_OpenEditViewEvent);
            (editcome as global::Main.Interface.ThempEdit).OpenEditCodeEvent += new ParameterHander<ThempEdit, PlugEventArgs>(FrmMain_OpenEditCodeEvent);
            (editcome as global::Main.Interface.ThempEdit).ShowDemoEvent += new ParameterHander<ThempEdit, PlugEventArgs>(FrmMain_ShowDemoEvent);
            (editcome as global::Main.Interface.ComeBaseModule.BaseCome).ComeExceptionEvent += new OnExceptionHandler<ComeRestException>(FrmMain_ComeExceptionEvent);
            // (editcome as ISynchronizeInvoke).BeginInvoke(new ThempEditCallBackHandle(SetControlCallBackMethod), null);
            this.Refresh();
            //(editcome as global::Main.Interface.ThempEdit).Invoke(null, null);//一定要同步调用，异步暂未实现，由于三重异步委托导致控件无法归位。
            FrmWait frmwait = new FrmWait();
            frmwait.TopMost = true;
            frmwait.Show();
            frmwait.Refresh();
            SendOrPostCallback callback = _ =>
            {
                frmwait.Close();
            };
            WindowsFormsSynchronizationContext currentcontext = WindowsFormsSynchronizationContext.Current as WindowsFormsSynchronizationContext;
            (editcome as global::Main.Interface.ThempEdit).SynchInvoke(currentcontext, callback);
        }

        void FrmMain_ComeExceptionEvent(ComeRestException ex)
        {
            WinFrmLifecycleEvent.OnErrFromShowInfo(ex.MessageInfo + ex.ComeName);
        }

        void FrmMain_ShowDemoEvent(ThempEdit sender, PlugEventArgs args)
        {
            (args.GetArgs() as WeifenLuo.WinFormsUI.Docking.DockContent).Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Float);
        }

        void FrmMain_OpenEditCodeEvent(ThempEdit sender, PlugEventArgs args)
        {
            Tools_info.Text = args.GetArgs().ToString();
        }
        void FrmMain_OpenEditViewEvent(ThempEdit sender, PlugEventArgs args)
        {
            (args.GetArgs() as WeifenLuo.WinFormsUI.Docking.DockContent).Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }
        public delegate void ThisDelegateHandler(object setobject);
        /// <summary>
        /// 在异步调用中，设置当前线程的控件状态，只能通过ISynchronizeInvoke接口设置
        /// </summary>
        /// <param name="IAsyncObject">IAsyncResult异步状态对象</param>
        private void SetControlCallBackMethod(IAsyncResult IAsyncObject, object IAsyncResultObject)
        {
            WeifenLuo.WinFormsUI.Docking.DockContent context =
                   (IAsyncResultObject as PlugEventArgs).GetArgs() as WeifenLuo.WinFormsUI.Docking.DockContent;
        }
        /// <summary>
        /// 该用法用在所有以Control为基类的对象上跨线程设置属性
        /// </summary>
        /// <param name="setobject">要设置的对象</param>
        private void ThisDelegateMethod(object setobject)
        {
            ((setobject as PlugEventArgs).GetArgs() as
                    WeifenLuo.WinFormsUI.Docking.DockContent).Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }
        //end模板编辑

        global::Main.Interface.ComeBaseModule.BaseCome aboutcome;
        private void Tools_about_Click(object sender, EventArgs e)
        {

        }

        global::Main.Interface.ComeBaseModule.BaseCome systemselectcome;
        private void Tools_SystemSele_Click(object sender, EventArgs e)
        {
            if (systemselectcome == null)
                systemselectcome = PlugManager.PlugKernelManager.MainEventProcess("http://www.emed.cc/CodeBuilderStudio/Details/SystemSetting") as BaseCome;
            if (systemselectcome == null)
                return;
            (systemselectcome as global::Main.Interface.SystemSetting).GetCodeThempPathEvent +=
                new SystemSettingHanlder<PlugEventArgs>(FrmMain_GetCodeThempPath);
            (systemselectcome as global::Main.Interface.SystemSetting).ShowSettingFrom();
        }

        void FrmMain_GetCodeThempPath(PlugEventArgs t)
        {
            FolderBrowserDialog browserfolder = new FolderBrowserDialog();
            browserfolder.Description = "浏览模板文件路径";
            if (browserfolder.ShowDialog() == DialogResult.OK)
            {
                (systemselectcome as global::Main.Interface.SystemSetting).OnCallBackCodeThempPath(browserfolder.SelectedPath);
            }
        }

        //重新启动切换程序
        private void Tools_changestart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ChangeStart.exe");

        }
        //打开开始窗口
        private void Tools_startfrm_Click(object sender, EventArgs e)
        {
            FrmStartPage._Currentfrm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }
        //项目窗口
        private void Tools_project_Click(object sender, EventArgs e)
        {
            FrmProject._Currentfrm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockRight);
        }
        //属性窗口
        private void Tools_property_Click(object sender, EventArgs e)
        {
            FrmPropertyInfo._Currentfrm.Show(dockPanel1, DockState.DockRight);
        }
        //数据源窗口
        private void Tools_datasource_Click(object sender, EventArgs e)
        {
            FrmDbServer._Currentfrm.Show(dockPanel1, DockState.DockLeft);
        }
        //错误窗口
        private void Tools_out_Click(object sender, EventArgs e)
        {
            FrmError._Currentfrm.Show(dockPanel1, DockState.DockBottom);
        }
        //异常窗口
        private void Tool_outfrom_Click(object sender, EventArgs e)
        {
            FrmOut._Currentfrm.Show(dockPanel1, DockState.DockBottom);
        }
        #endregion

        #region 工具栏事件
        private void Tools_toolssinglebuilder_Click(object sender, EventArgs e)
        {
            Tools_singlebuilder_Click(sender, e);
        }
        global::Main.Interface.UiBuilder uibuildercome;
        private void Tools_aspbuilder_Click(object sender, EventArgs e)
        {
            if (uibuildercome == null)
            {
                global::Main.Interface.ComeBaseModule.BaseCome basecome =
                    PlugManager.PlugKernelManager.MainEventProcess("http://www.emed.cc/CodeBuilderStudio/UiBuilder") as BaseCome;
                if (basecome != null)
                    uibuildercome = basecome as global::Main.Interface.UiBuilder;
                else
                    return;
            }
            uibuildercome.StartUiBuilderFormDontent += new OnExceptionHandler<IDockContent>(uibuildercome_StartUiBuilderFormDontent);
            (uibuildercome as global::Main.Interface.ComeBaseModule.BaseCome).StartCome();
        }

        void uibuildercome_StartUiBuilderFormDontent(IDockContent ex)
        {

        }
        global::Main.Interface.BuilderProcedure builderPr;
        //生成存储过程代码
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (builderPr == null)
            {
                global::Main.Interface.ComeBaseModule.BaseCome basecome =
                    PlugManager.PlugKernelManager.MainEventProcess("http://www.emed.cc/CodeBuilderStudio/BuilderProcedure") as BaseCome;
                if (basecome != null)
                    builderPr = basecome as global::Main.Interface.BuilderProcedure;
                else
                    return;
            }
            builderPr.Builder();
        }
        #endregion

        #region 单件生成窗口
        global::Main.Interface.SingleBuilder singlebuildercome;
        private void Tools_singlebuilder_Click(object sender, EventArgs e)
        {
            singlebuildercome = WinFrmLifecycleEvent.OnMainOperationSingleBuilderCome();
            if (singlebuildercome == null)
            {
                MessageBox.Show(this, "没有数据源的情况下，无法使用生成功能！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            (singlebuildercome as SingleBuilder).BrowserSaveFolder -= FrmMain_BrowserSaveFolder;
            (singlebuildercome as SingleBuilder).BrowserSaveFolder += new BrowserSaveDirectoryHandler<BrowserActivateType, StringBuilder>(FrmMain_BrowserSaveFolder);
            (singlebuildercome as OutInputInterface).ErrHandler += new Action<PlugEventArgs>(FrmMain_ErrHandler);
            (singlebuildercome as OutInputInterface).OutHandler += new Action<PlugEventArgs>(FrmMain_OutHandler);
            singlebuildercome.OpenMuilterSingleBuilderFrm();//打开单件生成构件窗口
        }
        //构件输出信息，送往输出窗口
        void FrmMain_OutHandler(PlugEventArgs obj)
        {
            WinFrmLifecycleEvent.OnOutFromShowInfo(obj.GetArgs().ToString());
        }
        //构件错误信息，送往错误窗口
        void FrmMain_ErrHandler(PlugEventArgs obj)
        {
            WinFrmLifecycleEvent.OnErrFromShowInfo(obj.GetArgs().ToString());
        }

        void FrmMain_BrowserSaveFolder(StringBuilder u)
        {
            FolderBrowserDialog folderbrowser = new FolderBrowserDialog();
            if (folderbrowser.ShowDialog() == DialogResult.OK)
            {
                u.Append(folderbrowser.SelectedPath);
            }
        }

        #endregion

        #region 启动实时代码交互环境
        global::Main.Interface.ComeBaseModule.BaseCome readcodesetting;
        private void Tools_realsetting_Click(object sender, EventArgs e)
        {

        }
        void FrmMain_ShowFrmEvent(PlugEventArgs t)
        {
            (t.GetArgs() as WeifenLuo.WinFormsUI.Docking.DockContent).Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 启动主界面中的所有设计界面
        /// </summary>
        public WeifenLuo.WinFormsUI.Docking.IDockContent LoadDesignFrm(string loadfrmstring)
        {
            if (loadfrmstring == typeof(FrmDbServer).ToString())
            {
                //启动数据源界面
                return FrmDbServer._Currentfrm;
            }
            else if (loadfrmstring == typeof(FrmStartPage).ToString())
            {
                //启动起始页面界面
                return FrmStartPage._Currentfrm;
            }
            else if (loadfrmstring == typeof(FrmProject).ToString())
            {
                //启动项目界面
                return FrmProject._Currentfrm;
            }
            else if (loadfrmstring == typeof(FrmPropertyInfo).ToString())
            {
                //启动属性界面
                return FrmPropertyInfo._Currentfrm;
            }
            else if (loadfrmstring == typeof(FrmError).ToString())
            {
                //输出界面
                return FrmError._Currentfrm;
            }
            else if (loadfrmstring == typeof(FrmOut).ToString())
            {
                return FrmOut._Currentfrm;
            }
            else
            {
                return null;
            }
        }
        public void LoadDesignFrm()
        {
            //启动数据源界面
            FrmDbServer._Currentfrm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
            //启动起始页面界面
            FrmStartPage._Currentfrm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
            //启动项目界面
            FrmProject._Currentfrm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockRight);
            FrmProject._Currentfrm.DockTo(dockPanel1, DockStyle.Right);
            //启动属性界面
            FrmPropertyInfo._Currentfrm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockRight);
            FrmPropertyInfo._Currentfrm.DockTo(dockPanel1, DockStyle.Right);
            //错误界面
            FrmError._Currentfrm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockBottomAutoHide);
            //输出界面
            FrmOut._Currentfrm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockBottomAutoHide);
        }
        /// <summary>
        /// 添加视图对象到主容器
        /// </summary>
        /// <param name="content">视图窗口对象</param>
        public void AddFrmView(WeifenLuo.WinFormsUI.Docking.DockContent content)
        {
            content.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }
        /// <summary>
        /// 实例化打开项目构件，以基类返回
        /// </summary>
        /// <returns>BaseCome</returns>
        private BaseCome NewBaseCome()
        {
            return (PlugManager.PlugKernelManager.MainEventProcess(
                "http://www.emed.cc/CodeBuilderStudio/Details/OpenProject") as BaseCome);
        }
        /// <summary>
        /// 根据构建命名空间
        /// </summary>
        /// <param name="codexmlnamespace">构建命名空间</param>
        /// <returns></returns>
        private BaseCome NewBaseCome(string codexmlnamespace)
        {
            return (PlugManager.PlugKernelManager.MainEventProcess(codexmlnamespace) as BaseCome);
        }
        #endregion


    }
}
