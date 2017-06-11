using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DataSourceOpen.Come
{
    public partial class FrmTableViewContainer : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        #region 控件字段、属性、构造函数、事件方法
        public FrmTableViewContainer()
        {
            InitializeComponent();
            panel1.Parent = this;
        }
        #endregion

        #region 容器绘制方法
        /// <summary>
        /// 缓冲位图
        /// </summary>
        Bitmap map;
        /// <summary>
        /// 绘制刻度条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DesignPanel_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                map = new Bitmap(this.Width, this.Height);
                Graphics grap = Graphics.FromImage(map);
                grap.SmoothingMode = SmoothingMode.AntiAlias;
                grap.Clear(Color.White);
                grap.DrawRectangle(Pens.White, this.ClientRectangle);
                List<Point> result = GetDrwingPointsHeight();
                for (int i = 0; i < result.Count; i++)
                {
                    grap.DrawLine(Pens.Black, result[i], new Point(result[i].X + 6, result[i].Y));
                    if (i % 10 == 0)
                        grap.DrawLine(Pens.Black, result[i], new Point(result[i].X + 10, result[i].Y));
                }
                result = GetDrawingPointsWidth();
                for (int i = 0; i < result.Count; i++)
                {
                    grap.DrawLine(Pens.Black, result[i], new Point(result[i].X, result[i].Y + 6));
                    if (i % 10 == 0)
                        grap.DrawLine(Pens.Black, result[i], new Point(result[i].X, result[i].Y + 10));
                }
                result = GetDrawingPointsRight();
                for (int i = 0; i < result.Count; i++)
                {
                    grap.DrawLine(Pens.Black, result[i], new Point(result[i].X - 6, result[i].Y));
                    if (i % 10 == 0)
                        grap.DrawLine(Pens.Black, result[i], new Point(result[i].X - 10, result[i].Y));
                }
                result = GetDrawingPointsBottom();
                for (int i = 0; i < result.Count; i++)
                {
                    grap.DrawLine(Pens.Black, result[i], new Point(result[i].X, result[i].Y - 6));
                    if (i % 10 == 0)
                        grap.DrawLine(Pens.Black, result[i], new Point(result[i].X, result[i].Y - 10));
                }
                Graphics g = Graphics.FromHwnd(this.Handle);
                g.DrawImage(map, 0, 0);
            }
            catch { }
            finally { map.Dispose(); }
        }
        /// <summary>
        /// 绘制刻度条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DesignPanel_Resize(object sender, EventArgs e)
        {
            DesignPanel_Paint(null, null);
        }
        /// <summary>
        /// 获取绘制的线段集合Height
        /// </summary>
        /// <returns>线段集合</returns>
        private List<Point> GetDrwingPointsHeight()
        {
            List<Point> result = new List<Point>();
            int height = this.ClientRectangle.Height;
            for (int i = 0; i < height; i = i + 10)
            {
                Point p = new Point(0, i);
                result.Add(p);
            }
            return result;
        }
        /// <summary>
        /// 获取绘制的线段集合Width
        /// </summary>
        /// <returns>线段集合</returns>
        private List<Point> GetDrawingPointsWidth()
        {
            List<Point> result = new List<Point>();
            int widht = this.ClientRectangle.Width;
            for (int i = 0; i < widht; i = i + 10)
            {
                Point p = new Point(i, 0);
                result.Add(p);
            }
            return result;
        }
        /// <summary>
        /// 获取绘制的线段集合Right
        /// </summary>
        /// <returns>线段的集合</returns>
        private List<Point> GetDrawingPointsRight()
        {
            List<Point> result = new List<Point>();
            int height = this.ClientRectangle.Height;
            for (int i = 0; i < height; i = i + 10)
            {
                Point p = new Point(this.ClientRectangle.Width, i);
                result.Add(p);
            }
            return result;
        }
        /// <summary>
        /// 获取绘制的线段集合Bottom
        /// </summary>
        /// <returns>线段集合</returns>
        private List<Point> GetDrawingPointsBottom()
        {
            List<Point> result = new List<Point>();
            int widht = this.ClientRectangle.Width;
            for (int i = 0; i < widht; i = i + 10)
            {
                Point p = new Point(i, this.ClientRectangle.Height);
                result.Add(p);
            }
            return result;
        }
        #endregion

        #region 窗体事件
        Stack<SizeF> StackSizef = new Stack<SizeF>();
        private void Tools_max_Click(object sender, EventArgs e)
        {
            //this.panel1.Scale(new SizeF(1.11f, 1.11f));
            //StackSizef.Push(new SizeF(0.9f, 0.9f));
        }

        private void Tools_min_Click(object sender, EventArgs e)
        {
            //this.panel1.Scale(new SizeF(0.9f, 0.9f));
            //StackSizef.Push(new SizeF(1.11f, 1.11f));
        }

        private void Tools_restore_Click(object sender, EventArgs e)
        {

        }
        private void FrmTableViewContainer_Load(object sender, EventArgs e)
        {

        }

        private void Tools_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        public ControlTableView ActivatedView;//保存激活控件的对象
        public List<ControlTableView> ChildActivatedView = new List<ControlTableView>();//子控件集合
        private void Tools_deleview_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "是否删除所有视图面板？还是仅仅删除激活面板", "信息提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                for (int i = 0; i < ChildActivatedView.Count; i++)
                {
                    ChildActivatedView[i].Dispose();
                }
                if (ActivatedView != null)
                    ActivatedView.Dispose();
                return;
            }
            if (ActivatedView != null)
                ActivatedView.Dispose();
        }
        private delegate void RunPreviewDelegateHandler();
        RunPreviewDelegateHandler RunPreview;
        Command.PrintTableView printview;
        private void Toos_preview_Click(object sender, EventArgs e)
        {
            printview = new DataSourceOpen.Come.Command.PrintTableView(GetTableDataSrouce(), this);
            RunPreview = new RunPreviewDelegateHandler(printview.Preview);
            printview.Preview();
            //RunPreview.BeginInvoke(null, null);//在没有跨线程操作Control对象时使用
        }

        private void Toos_printc_Click(object sender, EventArgs e)
        {
            printview = new DataSourceOpen.Come.Command.PrintTableView(GetTableDataSrouce(), this);
            printview.Print();
        }
        private List<DataTable> GetTableDataSrouce()
        {
            List<DataTable> list = new List<DataTable>();
            foreach (Control child in ChildActivatedView)
            {
                list.Add(Command.DataSourceCommand.GetTableColumnsInfo(
                    (child as ControlTableView).thisconnstring, (child as ControlTableView).thistbname));
            }
            return list;
        }

        private void reflectionLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("Explorer", "http://www.cnblogs.com/wangiqngpei557/");
        }
    }
}
