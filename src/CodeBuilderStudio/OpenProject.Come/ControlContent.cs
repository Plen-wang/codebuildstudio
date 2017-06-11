/*
 *author:南京.王清培
 *coding time:2011.7.10
 *copyright:快捷速递
 *function:打开项目构件，实现Main.Interface.OpenProject接口
 */
using System;
using System.Collections.Generic;
using System.Text;
using Main.Interface.ComeBaseModule;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace OpenProject.Come
{
    /// <summary>
    /// 继承构件基类，没有完全实现构件，继续向下传递实现；
    /// </summary>
    [Main.Interface.Attribute.WheTherNextTransfer(IfNextTransfer = true, ChildAssembly = "OpenProject.Come.Childe1",
        ChildInterface = "OpenProject.Interface.NextComeInterface")]
    public class ControlContent : BaseCome, Main.Interface.OpenProject
    {
        public ControlContent() { }
        /// <summary>
        /// 重载构造函数，初始化构件的基本属性
        /// </summary>
        /// <param name="comename">构件名称</param>
        /// <param name="loadpath">构件的加载路径</param>
        /// <param name="time">装载时间</param>
        public ControlContent(string comename, string loadpath, DateTime time) : base(comename, loadpath, time) { }

        #region OpenProject 成员

        public string ProjectPath { get; set; }
        public void OpenProject(TreeView tv)
        {
            BindTreeViewNode(tv);
        }
        public event Main.Interface.BrowserFileCodeFrmHandler BrowserFileCodeFrmEvent;
        public void BrowserFileCode(object tagobject)//打开文件查看代码
        {
            Module.M_DomBase basedom = (tagobject as Module.M_DomBase);//获取对象的基类，用统一的方法获取其他实例的方法
            if (basedom == null)
                return;

            FileStream filestream = File.OpenRead(basedom.GetDomFilePath());

            byte[] codebyte = new byte[filestream.Length];

            filestream.Read(codebyte, 0, codebyte.Length);

            StringBuilder codebuilder = new StringBuilder();
            codebuilder.Append(Encoding.UTF8.GetString(codebyte));

            FrmCodePage code = new FrmCodePage(filestream.Name, codebuilder.ToString());

            filestream.Close();
            filestream.Dispose();

            BrowserFileCodeFrmEvent(code);

        }

        private Main.Interface.SetProjectNodeHandler _setprojectnodeeventhandler;
        public event Main.Interface.SetProjectNodeHandler SetProjectNodeEvent
        {
            add
            {
                if (_setprojectnodeeventhandler == null)
                    _setprojectnodeeventhandler += value;
            }
            remove
            {
                if (_setprojectnodeeventhandler != null)
                    _setprojectnodeeventhandler -= value;
            }
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 绑定TreeView节点
        /// </summary>
        /// <param name="tv">TreeView</param>
        private void BindTreeViewNode(System.Windows.Forms.TreeView tv)
        {
            Module.M_DomResolvent Resolvent = Command.OpenFileDirectory.OpenDirectory(ProjectPath);
            TreeNode resolventnode = new TreeNode();
            resolventnode.Text = Resolvent.FileName;
            resolventnode.Tag = Resolvent;
            resolventnode.ImageIndex = 0;
            resolventnode.SelectedImageIndex = 0;
            _setprojectnodeeventhandler(Resolvent.FilePath);//触发设置节点事件，让前端程序能有个反馈

            #region 项目的设计
            for (int i = 0; i < Resolvent.ProjectCollection.Count; i++)
            {
                TreeNode projectnode = new TreeNode();
                projectnode.Text = Resolvent.ProjectCollection[i].FileName;
                projectnode.ImageIndex = 1;
                projectnode.SelectedImageIndex = 1;
                projectnode.Tag = Resolvent.ProjectCollection[i];
                _setprojectnodeeventhandler(Resolvent.ProjectCollection[i].FilePath);//触发设置节点

                #region 项目的Properties文件夹设计
                for (int j = 1; j < Resolvent.ProjectCollection[i]._dir[0].DirCollection.Count; j++)
                {
                    if (Resolvent.ProjectCollection[i]._dir[0].DirCollection[j].DirectoryType == Module.DirType.Propertties)
                    {
                        TreeNode propertynode = new TreeNode();
                        propertynode.Text = Resolvent.ProjectCollection[i]._dir[0].DirCollection[j].FileName;
                        propertynode.ImageIndex = 4;
                        propertynode.SelectedImageIndex = 4;
                        _setprojectnodeeventhandler(Resolvent.ProjectCollection[i]._dir[0].DirCollection[j].FileName);//触发设置节点事件

                        foreach (Module.M_DomCs cs in Resolvent.ProjectCollection[i]._dir[0].DirCollection[j].CsFileCollection)
                        {
                            TreeNode childnode = new TreeNode();
                            childnode.Text = cs.FileName;
                            childnode.ImageIndex = 10;
                            childnode.SelectedImageIndex = 10;
                            propertynode.Nodes.Add(childnode);
                            _setprojectnodeeventhandler(cs.FileName);//触发设置节点事件
                        }
                        projectnode.Nodes.Add(propertynode);
                        Resolvent.ProjectCollection[i]._dir[0].DirCollection.RemoveAt(j);//将项目的属性文件夹移除
                        break;
                    }
                }
                #endregion

                #region 引用文件夹的设计
                TreeNode refnode = new TreeNode();
                refnode.Text = "引用";
                refnode.ImageIndex = 5;
                refnode.SelectedImageIndex = 6;
                foreach (string sub in Resolvent.ProjectCollection[i]._reflection)
                {
                    TreeNode subnode = new TreeNode();
                    subnode.Text = sub;
                    subnode.ImageIndex = 7;
                    subnode.SelectedImageIndex = 7;
                    refnode.Nodes.Add(subnode);
                }
                projectnode.Nodes.Add(refnode);
                #endregion

                #region 常规文件夹的设计
                for (int j = 0; j < Resolvent.ProjectCollection[i]._dir[0].DirCollection.Count; j++)
                {
                    TreeNode commonnode = new TreeNode();
                    commonnode.Text = Resolvent.ProjectCollection[i]._dir[0].DirCollection[j].FileName;
                    commonnode.ImageIndex = 2;
                    commonnode.SelectedImageIndex = 3;
                    commonnode.Tag = Resolvent.ProjectCollection[i]._dir[0].DirCollection[j];

                    for (int x = 0; x < Resolvent.ProjectCollection[i]._dir[0].DirCollection[j].CsFileCollection.Count; x++)
                    {
                        TreeNode csnode = new TreeNode();
                        csnode.Text = Resolvent.ProjectCollection[i]._dir[0].DirCollection[j].CsFileCollection[x].FileName;
                        csnode.Tag = Resolvent.ProjectCollection[i]._dir[0].DirCollection[j].CsFileCollection[x];
                        if (SetNodeIco(csnode, Resolvent.ProjectCollection[i]._dir[0].DirCollection[j].CsFileCollection[x]))
                            commonnode.Nodes.Add(csnode);
                    }
                    SetNodeDirectory(commonnode, Resolvent.ProjectCollection[i]._dir[0].DirCollection[j]);
                    projectnode.Nodes.Add(commonnode);
                }

                for (int j = 0; j < Resolvent.ProjectCollection[i]._dir[0].CsFileCollection.Count; j++)
                {
                    TreeNode csnode = new TreeNode();
                    csnode.Text = Resolvent.ProjectCollection[i]._dir[0].CsFileCollection[j].FileName;
                    csnode.Tag = Resolvent.ProjectCollection[i]._dir[0].CsFileCollection[j];
                    if (SetNodeIco(csnode, Resolvent.ProjectCollection[i]._dir[0].CsFileCollection[j]))
                    {
                        if (Resolvent.ProjectCollection[i]._dir[0].CsFileCollection[j]._cslist.Count > 0)
                        {
                            SetNodeChildIco(csnode, Resolvent.ProjectCollection[i]._dir[0].CsFileCollection[j]);
                        }
                        projectnode.Nodes.Add(csnode);
                    }
                }
                #endregion
                resolventnode.Nodes.Add(projectnode);

            }
            #endregion

            tv.Nodes.Clear();
            tv.Nodes.Add(resolventnode);


        }
        private bool SetNodeIco(TreeNode node, Module.M_DomCs cs)
        {
            switch (cs.IsType)
            {
                case Module.CsType.Cs: node.ImageIndex = node.SelectedImageIndex = 10; return true;
                case Module.CsType.img: node.ImageIndex = node.SelectedImageIndex = 17; return true;
                case Module.CsType.html: node.ImageIndex = node.SelectedImageIndex = 13; return true;
                case Module.CsType.aspx: node.ImageIndex = node.SelectedImageIndex = 14; return true;
                case Module.CsType.config: node.ImageIndex = node.SelectedImageIndex = 16; return true;
                case Module.CsType.resource: node.ImageIndex = node.SelectedImageIndex = 18; return true;
                case Module.CsType.winform: node.ImageIndex = node.SelectedImageIndex = 8; return true;
                case Module.CsType.js: node.ImageIndex = node.SelectedImageIndex = 11; return true;
                case Module.CsType.css: node.ImageIndex = node.SelectedImageIndex = 12; return true;
                case Module.CsType.disco: node.ImageIndex = node.SelectedImageIndex = 19; return true;
                case Module.CsType.wsdl: node.ImageIndex = node.SelectedImageIndex = 20; return true;
                case Module.CsType.map: node.ImageIndex = node.SelectedImageIndex = 21; return true;
                case Module.CsType.settings: node.ImageIndex = node.SelectedImageIndex = 21; return true;
                case Module.CsType.defaults: ; return false;//垃圾文件，不显示出来
            }
            return false;
        }
        private void SetNodeChildIco(TreeNode node, Module.M_DomCs csdom)
        {
            for (int i = 0; i < csdom._cslist.Count; i++)
            {
                TreeNode childnode = new TreeNode();
                childnode.Text = csdom._cslist[i].FileName;
                childnode.ImageIndex = 9;
                childnode.SelectedImageIndex = 9;
                node.Nodes.Add(childnode);
            }
        }
        private void SetNodeDirectory(TreeNode node, Module.M_DomDirectory dirdom)
        {
            foreach (Module.M_DomDirectory dir in dirdom.DirCollection)
            {
                if (dir.DirCollection.Count > 0)
                    SetNodeDirectory(node, dir);//继续递归遍历节点

                TreeNode dirnode = new TreeNode();
                dirnode.Text = dirdom.FileName;
                dirnode.ImageIndex = 2;
                dirnode.SelectedImageIndex = 3;
                dirnode.Tag = dir;

                foreach (Module.M_DomCs cs in dir.CsFileCollection)
                {
                    TreeNode csnode = new TreeNode();
                    csnode.Text = cs.FileName;
                    csnode.Tag = cs;
                    if (SetNodeIco(csnode, cs))
                    {
                        if (cs._cslist.Count > 0)
                        {
                            SetNodeChildIco(csnode, cs);
                        }
                        dirnode.Nodes.Add(csnode);
                    }
                }
                node.Nodes.Add(dirnode);
            }
        }
        #endregion

        /// <summary>
        /// 启动构件，进行生命使用
        /// </summary>
        public override void StartCome() { }
        /// <summary>
        /// 释放构件占用的托管、非托管资源
        /// </summary>
        public override void Dispose() { }


        #region OpenProject 成员


        public void Lookup(TreeView tv)
        {
            FrmLookUpTable lookup = new FrmLookUpTable(tv, Control.MousePosition);
            lookup.Show();
        }
        public void OpenFileDir(object nodeobject)
        {
            Module.M_DomBase basedom = (nodeobject as Module.M_DomBase);
            if (basedom == null)
                return;
            System.Diagnostics.Process.Start(Path.GetDirectoryName(basedom.FilePath));
        }
        #endregion
    }
}
