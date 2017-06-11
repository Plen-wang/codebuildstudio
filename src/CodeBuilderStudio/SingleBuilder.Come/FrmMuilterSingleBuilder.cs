using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections;
using System.Collections.Specialized;

namespace SingleBuilder.Come
{
    public partial class FrmMuilterSingleBuilder : Form
    {
        public FrmMuilterSingleBuilder()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmMuilterSingleBuilder_Load);
            this.Shown += new EventHandler(FrmMuilterSingleBuilder_Shown);
        }
        private ControlContent controlcontent;
        private List<string> _currenttblist;
        public FrmMuilterSingleBuilder(List<string> tblist, ControlContent content)
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmMuilterSingleBuilder_Load);
            this.Shown += new EventHandler(FrmMuilterSingleBuilder_Shown);
            _currenttblist = tblist;
            controlcontent = content;
        }
        void FrmMuilterSingleBuilder_Load(object sender, EventArgs e) { }
        void FrmMuilterSingleBuilder_Shown(object sender, EventArgs e)
        {
            Action<string> handler = _ =>
            {
                MessageBox.Show(this, "未能提供使用的表格数据源！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            if (_currenttblist == null)
            {
                handler(string.Empty);
                this.Close();
                return;
            }
            else if (_currenttblist.Count <= 0)
            {
                handler(string.Empty);
                this.Close();
                return;
            }
            //构造选择数据源
            _currenttblist.Sort();
            Clb_tblist.DataSource = _currenttblist;
            LoadThempFile();
        }

        private void Cb_statecheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_statecheck.Checked)
            {
                Cb_statecheck.Text = "全不选";
                for (int i = 0; i < Clb_tblist.Items.Count; i++)
                {
                    Clb_tblist.SetItemChecked(i, true);
                }
            }
            else
            {
                Cb_statecheck.Text = "全选";
                for (int i = 0; i < Clb_tblist.Items.Count; i++)
                {
                    Clb_tblist.SetItemChecked(i, false);
                }
            }
        }
        private void LoadThempFile()
        {
            ComeCommonMethod.ComeComon.ReaderThemp reader = new ComeCommonMethod.ComeComon.ReaderThemp(false);
            Clb_tempfile.DataSource = reader.GetThempList();
        }

        private void Btn_browserpath_Click(object sender, EventArgs e)
        {
            StringBuilder path = new StringBuilder();
            this.controlcontent.OpenFolderBrowserDialog(path);
            if (path.Length > 0)
                Tb_path.Text = path.ToString();
        }
        //根据用户选择的表信息、模板信息生成代码文件
        private void Btn_builder_Click(object sender, EventArgs e)
        {
            #region 提示信息
            Action<string> messageaction = (string mes) =>
            {
                MessageBox.Show(this, mes, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            if (Clb_tblist.CheckedItems.Count <= 0)
            {
                messageaction("请选择要生成的表!"); return;
            }
            if (Clb_tempfile.CheckedItems.Count <= 0)
            {
                messageaction("请选择生成模板！"); return;
            }
            if (Tb_path.Text.Length <= 0)
            {
                messageaction("请选择保存文件的路径!"); return;
            }
            #endregion

            //传递到异步线程的参数。
            //1：是同步上下文，2：是设置进度条最大值的委托实例，3：是设置进度条的Value值的委托实例。
            Hashtable threadobject = new Hashtable();
            threadobject.Add("synccontext", WindowsFormsSynchronizationContext.Current);//添加同步上下文
            SendOrPostCallback setmaxvaluecallback = (object values) =>//设置进度条的最大MAX值委托实例
            {
                progressBar1.Maximum = int.Parse(values.ToString());//设置最大值

            };
            threadobject.Add("setmax", setmaxvaluecallback);
            SendOrPostCallback setvaluecallback = (object values) =>//设置进度条值的回调委托
            {
                progressBar1.Value += int.Parse(values.ToString());//设置进度条值
            };
            threadobject.Add("setvalue", setvaluecallback);
            Action<Hashtable> actionbuilder = BuilderCode;//异步执行委托实例

            progressBar1.Visible = true;
            AsyncCallback endcallback = (IAsyncResult state) =>
            {
                SynchronizationContext syncontext = state.AsyncState as SynchronizationContext;
                SendOrPostCallback endcallbacksync = _ =>
                {
                    progressBar1.Visible = false;
                    MessageBox.Show(this, "生成结束！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                syncontext.Send(endcallbacksync, null);
            };
            actionbuilder.BeginInvoke(threadobject, endcallback, WindowsFormsSynchronizationContext.Current);
        }
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="threadobject">夸线程传递参数
        /// 1：是同步上下文，2：是设置进度条最大值的委托实例，3：是设置进度条的Value值的委托实例。</param>
        private void BuilderCode(Hashtable threadobject)
        {
            try
            {
                CheckedListBox.CheckedItemCollection vmlist = Clb_tempfile.CheckedItems; //获取选择的模板名称列表
                CheckedListBox.CheckedItemCollection tblist = Clb_tblist.CheckedItems;//选择要生成的表集合
                //在选择的位置创建文件夹用来保存生成后的源文件
                if (!Directory.Exists(Path.Combine(Tb_path.Text, "Glory.net生成文件夹")))
                    Directory.CreateDirectory(Path.Combine(Tb_path.Text, "Glory.net生成文件夹"));//顶层文件夹
                foreach (string vmname in vmlist)
                {
                    if (!Directory.Exists(Path.Combine(Tb_path.Text, "Glory.net生成文件夹\\" + vmname)))
                        Directory.CreateDirectory(Path.Combine(Tb_path.Text, "Glory.net生成文件夹\\" + vmname));//创建模板文件夹
                }

                SynchronizationContext synccontext = threadobject["synccontext"] as SynchronizationContext;//获取同步上下文
                synccontext.Send(threadobject["setmax"] as SendOrPostCallback, tblist.Count);//设置进度条最大值

                foreach (string tbname in tblist)
                {
                    synccontext.Send(threadobject["setvalue"] as SendOrPostCallback, 1);//递增进度条
                    foreach (string vmname in vmlist)
                    {
                        //根据模板生成源文件
                        UnManagerCodeEngine.UnManager.DataSourceType datasource;
                        if ((controlcontent as Main.Interface.SingleBuilder).BuilderSourceType ==
                            Main.Interface.DataSourceType.MicrosfotSqlServer)
                            datasource = UnManagerCodeEngine.UnManager.DataSourceType.MsSqlServer;
                        else
                            datasource = UnManagerCodeEngine.UnManager.DataSourceType.Oracle;

                        //利用DataSourceOpen接口获取数据源
                        DataTable columndt = new DataTable();
                        object ptable = new object();
                        if (!Cb_store.Checked)
                        {
                            //获取生成表、试图的数据源
                            controlcontent.CurrentDataSource.GetMuilterSingleDataSource(tbname, out columndt);
                        }
                        else
                        {
                            //获取存储过程的数据源
                            controlcontent.CurrentDataSource.GetProcedure(tbname, out ptable);
                            columndt = ptable as DataTable;
                        }
                        UnManagerCodeEngine.UnManager.BuilderCodeType codetype = UnManagerCodeEngine.UnManager.BuilderCodeType.Table;
                        if (Cb_store.Checked)
                            codetype = UnManagerCodeEngine.UnManager.BuilderCodeType.Store;

                        string codestr = UnManagerCodeEngine.UnManager.ProcessUnManager(vmname + ".vm", columndt, datasource, codetype);

                        string glorydir = Path.Combine(Tb_path.Text, "Glory.net生成文件夹\\" + vmname);

                        if (File.Exists(Path.Combine(glorydir, vmname) + "\\" + tbname + ".cs"))
                            File.Create(Path.Combine(glorydir, vmname) + "\\" + tbname + ".cs");

                        using (FileStream stream = File.Open(Path.Combine(glorydir, tbname) + ".cs", FileMode.Create, FileAccess.Write))
                        {
                            byte[] builbyte = Encoding.UTF8.GetBytes(codestr);
                            stream.Write(builbyte, 0, builbyte.Length);
                        }
                        string outinfo = string.Format(tbname + "生成成功！保存地址为：{0}", Path.Combine(glorydir, tbname));
                        controlcontent.OnOutHandler(outinfo);
                    }
                }
            }
            catch (Exception err) { controlcontent.OnErrHandler(err.Message); }
        }


        private void Cb_store_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_store.Checked)
            {
                label1.Text = "选择生成的存储过程";
                object list;
                controlcontent.CurrentDataSource.GetProcedure(string.Empty, out list);
                Clb_tblist.DataSource = list;
            }
            else
            {
                label1.Text = "选择生成的表";
                Clb_tblist.DataSource = _currenttblist;
            }
        }

        private void Btn_look_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Clb_tblist.Items.Count; i++)
            {
                if (Clb_tblist.Items[i].Equals(Tb_prname.Text))
                {
                    Clb_tblist.SelectedItem = Clb_tblist.Items[i]; break;
                }
            }
        }
    }
}
