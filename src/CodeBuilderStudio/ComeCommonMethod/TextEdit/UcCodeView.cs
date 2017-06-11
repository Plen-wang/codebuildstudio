using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;

namespace ComeCommonMethod
{
    public partial class UcCodeView : UserControl
    {
        #region 构造函数及属性字段
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public UcCodeView()
        {
            InitializeComponent();
            this.Load += new EventHandler(UcCodeView_Load);
            //初始化文本编辑器
            SetEditStyle();
        }

        void UcCodeView_Load(object sender, EventArgs e)
        {
            Tools_codetype.SelectedIndex = Tools_encoding.SelectedIndex = 0;
        }
        [Browsable(true)]
        public bool ToolsVisble
        {
            get { return toolStrip1.Visible; }
            set { toolStrip1.Visible = value; }
        }
        /// <summary>
        /// 代码字段
        /// </summary>
        private string _codetext;
        /// <summary>
        /// 代码属性
        /// </summary>
        [Browsable(true)]
        public string CodeText
        {
            set
            {
                _codetext = value;
                scin.Text = _codetext;
            }
            get { return _codetext; }
        }

        public string SaveCodeText
        {
            get { return scin.Text; }
        }
        #endregion

        #region 工具栏事件
        private void Tools_encoding_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Tools_codetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ecode = Tools_codetype.SelectedItem.ToString();
            scin.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy(ecode);
        }
        /// <summary>
        /// 保存按钮事件，从内部对象传出来的事件，可以订阅已进行多功能代码的保存。
        /// </summary>
        public event EventHandler P_Tools_save_Click;

        private void Tools_save_Click(object sender, EventArgs e)
        {
            if (P_Tools_save_Click == null)
                return;
            if (P_Tools_save_Click.GetInvocationList().Length > 0)
                P_Tools_save_Click(sender, e);
        }

        private void Tools_print_Click(object sender, EventArgs e)
        {

        }

        private void Tools_zoomin_Click(object sender, EventArgs e)
        {

        }

        private void Tools_zoomout_Click(object sender, EventArgs e)
        {

        }

        bool isinsert = false;
        private void Tools_insert_Click(object sender, EventArgs e)
        {
            if (isinsert)
            {
                Tools_insert.CheckState = CheckState.Unchecked;
                Tools_insert.Text = "打开智能提示";
                isinsert = false;
            }
            else
            {
                Tools_insert.CheckState = CheckState.Checked;
                Tools_insert.Text = "取消智能提示";
                isinsert = true;
            }
        }
        #endregion

        #region 文本编辑器设置
        /// <summary>
        /// 基本设置
        /// </summary>
        private void SetEditStyle()
        {
            scin.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
        }
        /// <summary>
        /// 自动完成输入设置
        /// </summary>
        private void SetAutoComplete()
        {

        }

        #region AutoComplete事件

        void scin_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion


        #endregion
    }
}