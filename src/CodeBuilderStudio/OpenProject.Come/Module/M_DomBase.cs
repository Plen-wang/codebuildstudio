using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing.Design;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms.Design;

namespace OpenProject.Come.Module
{
    /// <summary>
    /// 实体基类，用来统一所有DOM对象，以方便管理。
    /// </summary>
    public abstract class M_DomBase
    {
        /// <summary>
        /// 文件的物理路径
        /// </summary>
        [Category("数据"), Description("文件的物理路径"), ReadOnly(true)]
        //[Editor(typeof(PathEditUI), typeof(UITypeEditor)), Localizable(true)]
        public string FilePath { get; set; }
        /// <summary>
        /// 文件的逻辑名称
        /// </summary>
        [Category("数据"), Description("文件的逻辑名称"), ReadOnly(true)]
        public string FileName { get; set; }
        /// <summary>
        /// 抽象方法，子类用来进行自己的路径返回
        /// </summary>
        /// <returns>文件的路径</returns>
        public virtual string GetDomFilePath()
        {
            return FilePath;
        }
        /// <summary>
        /// 获取文件的逻辑名称
        /// </summary>
        /// <returns>文件的逻辑名称</returns>
        public virtual string GetDomFileName()
        {
            return FileName;
        }
    }

    public class PathEditUI : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            U_ContrlPath control = new U_ContrlPath();
            IWindowsFormsEditorService wineditservice =
                provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            //wineditservice.DropDownControl(control);//设置编辑框的呈现方式
            wineditservice.ShowDialog(new Module.FrmProperty());

            return base.EditValue(context, provider, value);
        }
    }
}
