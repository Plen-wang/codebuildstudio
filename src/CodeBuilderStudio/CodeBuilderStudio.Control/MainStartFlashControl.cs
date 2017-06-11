using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CodeBuilderStudio.Control
{
    public partial class MainStartFlashControl : UserControl
    {
        #region 控件变量及构造函数
        /// <summary>
        /// 加载信息
        /// </summary>
        [Browsable(true), Description("界面加载时的显示信息")]
        public string InitInfo
        {
            set { label1.Text = value; }
        }
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public MainStartFlashControl()
        {
            InitializeComponent();
        }
        #endregion
    }
}
