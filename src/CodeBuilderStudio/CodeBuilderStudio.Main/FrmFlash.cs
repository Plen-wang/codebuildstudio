using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeBuilderStudio.Main
{
    public partial class FrmFlash : Form
    {
        #region 窗体变量及构造函数

        /// <summary>
        /// 设置启动界面启动时的提示信息
        /// </summary>
        public string InitInfo
        {
            set { mainStartFlashControl1.InitInfo = value; }
        }
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public FrmFlash()
        {
            InitializeComponent();

        }
        #endregion
    }
}
