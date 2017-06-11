using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OpenProject.Come
{
    public partial class FrmLookUpTable : Form
    {
        #region 类变量及构造函数
        /// <summary>
        /// 上下问查找对象
        /// </summary>
        TreeView Treev;
        /// <summary>
        /// 重载构造函数，实现对主程序的表集合里表进行查找
        /// </summary>
        public FrmLookUpTable(TreeView tv, Point location)
        {
            InitializeComponent();
            Treev = tv;
            this.Location = location;
        }
        #endregion

        #region 窗体事件
        private void FrmLookUp_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Treev.Nodes.Count; i++)
            {
                RecursionNode(Treev.Nodes[i], Tb_tbname.Text.Trim());
            }
        }
        bool ismove = false;
        Point islocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ismove = true;
            islocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismove)
            {
                Point move = Control.MousePosition;
                move.Offset(islocation);
                this.Location = move;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            ismove = false;
        }
        private void Lb_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Lb_close_MouseEnter(object sender, EventArgs e)
        {
            Lb_close.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Lb_close_MouseLeave(object sender, EventArgs e)
        {
            Lb_close.BorderStyle = BorderStyle.None;
        }
        #endregion

        #region 窗体公共方法
        /// <summary>
        /// 递归检索指定名称的节点
        /// </summary>
        /// <param name="parent">节点</param>
        /// <param name="nodetext">节点的文本</param>
        private void RecursionNode(TreeNode parent, string nodetext)
        {
            foreach (TreeNode node in parent.Nodes)
            {
                if (node.Nodes.Count > 0)//说明下面还有子节点
                {
                    RecursionNode(node, nodetext);//递归进行节点深度遍历
                }
                if (node.Text == nodetext)
                {
                    node.NodeFont = new Font("宋体", 10, FontStyle.Italic);
                    this.Close();
                    return;//返回调用堆栈
                }
            }
        }
        #endregion

    }
}
