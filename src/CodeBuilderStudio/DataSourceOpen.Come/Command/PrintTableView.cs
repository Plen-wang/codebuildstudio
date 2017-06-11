using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace DataSourceOpen.Come.Command
{
    /// <summary>
    /// 视图面板打印
    /// </summary>
    public class PrintTableView
    {
        private PrintDocument Pdocument = new PrintDocument();
        private PrintPreviewDialog Ppreview = new PrintPreviewDialog();
        private PrintDialog Pdialog = new PrintDialog();
        private PageSetupDialog Pagedialog = new PageSetupDialog();
        private PageSettings Pagesetting = new PageSettings();
        private List<DataTable> viewlist = new List<DataTable>();
        private Form Parent;
        public PrintTableView(List<DataTable> view, Form f)
        {
            Pdocument.DocumentName = "Glory.NET代码生成器";
            Pdocument.PrintPage += new PrintPageEventHandler(Pdocument_PrintPage);
            Ppreview.Document = Pdocument;
            Ppreview.ShowIcon = false;

            Pdialog.Document = Pdocument;
            Pdialog.AllowCurrentPage = true;
            Pdialog.AllowPrintToFile = true;
            Pdialog.AllowSelection = true;
            Pdialog.AllowSomePages = true;

            Pagedialog.PageSettings = Pagesetting;
            viewlist = view;
            Parent = f;
        }
        public void Preview()
        {
            Pdialog.ShowDialog(Parent);
            Pagedialog.ShowDialog(Parent);
            Pdocument.DefaultPageSettings = Pagesetting;
            Ppreview.ShowDialog(Parent);
        }
        public void Print()
        {
            Pdialog.ShowDialog(Parent);
            Pagedialog.ShowDialog(Parent);
            Pdocument.DefaultPageSettings = Pagesetting;
            Pdocument.Print();
        }

        int currentpage = 0;//表的索引
        int rowindex = 0;//行的索引
        bool continuerow = false;//是否续打行
        float x = 0;
        float y = 0;
        int pageindex = 1;
        void Pdocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (continuerow == false)
            {
                if (currentpage == viewlist.Count)
                    currentpage = 0;//重新打印，开始新的标记
            }

            e.Graphics.PageUnit = GraphicsUnit.Display;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            y = 0;
            Font f = new Font("宋体", 40, FontStyle.Italic | FontStyle.Bold);
            e.Graphics.TranslateTransform(0, 800);
            e.Graphics.RotateTransform(280);
            e.Graphics.DrawString(pageindex++.ToString() + "Glory.NET代码生成器", f, Brushes.LightGray, 100, 700);
            e.Graphics.ResetTransform();
            for (; currentpage < viewlist.Count; currentpage++)
            {
                e.Graphics.DrawString("TableName：" + viewlist[currentpage].TableName, new Font("宋体", 20, FontStyle.Bold), Brushes.Black, 5, (y += 25));//表头
                PrintDataTableRow(viewlist[currentpage], e);//打印行
                if (continuerow)
                {
                    e.HasMorePages = true;
                    break;
                }
                rowindex = 0;//新的表打印
                float viewheight = e.PageBounds.Height;
                if (y >= viewheight)
                {
                    e.HasMorePages = true;//打印附加页
                    break;
                }
            }

        }
        void PrintDataTableRow(DataTable dt, PrintPageEventArgs e)
        {
            for (; rowindex < dt.Rows.Count; rowindex++)
            {
                if (y >= (e.PageBounds.Height - 60))
                {
                    continuerow = true;//下一页继续打印
                    break;
                }
                x = 5;
                SizeF strsize = e.Graphics.MeasureString(viewlist[currentpage].TableName, new Font("宋体", 20, FontStyle.Bold));
                y += strsize.Height;
                e.Graphics.DrawLine(Pens.LightGray, (e.PageBounds.Height - x), (e.PageBounds.Width - y), y, e.PageBounds.Height);

                e.Graphics.DrawString(dt.Rows[rowindex][0].ToString(), new Font("宋体", 15), Brushes.Black, x += 5, y);
                x += e.Graphics.MeasureString(dt.Rows[rowindex][0].ToString(), new Font("宋体", 15)).Width + 10;//向左偏移

                e.Graphics.DrawString(dt.Rows[rowindex][1].ToString(), new Font("宋体", 15), Brushes.Black, x += 5, y);
                x += e.Graphics.MeasureString(dt.Rows[rowindex][1].ToString(), new Font("宋体", 15)).Width + 10;//向左偏移

                e.Graphics.DrawString(dt.Rows[rowindex][2].ToString(), new Font("宋体", 15), Brushes.Black, x += 5, y);
                x += e.Graphics.MeasureString(dt.Rows[rowindex][2].ToString(), new Font("宋体", 15)).Width + 10;//向左偏移

                if (y >= (e.PageBounds.Height - 60))
                {
                    continuerow = true;//下一页继续打印
                    rowindex += 1;
                    break;
                }
            }
            if (rowindex == dt.Rows.Count)
                continuerow = false;
        }
    }
}
