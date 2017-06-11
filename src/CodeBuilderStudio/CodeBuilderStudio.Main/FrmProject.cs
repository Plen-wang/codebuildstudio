using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Main.Interface;

namespace CodeBuilderStudio.Main
{
    public partial class FrmProject : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private static FrmProject _thisfrm;
        public static FrmProject _Currentfrm
        {
            get
            {
                if (_thisfrm == null)
                    _thisfrm = new FrmProject();
                return _thisfrm;
            }
        }
        public FrmProject()
        {
            InitializeComponent();
            _thisfrm = this;
            WinFrmLifecycleEvent.BrowserProjectEvent += new BrowserProjectHandler(WinFrmLifecycleEvent_BrowserProjectEvent);
            WinFrmLifecycleEvent.CloseGlobalEvent += new EventHandler(WinFrmLifecycleEvent_CloseGlobalEvent);
        }

        void WinFrmLifecycleEvent_CloseGlobalEvent(object sender, EventArgs e)
        {
            this.Tv_filebrowser.Nodes.Clear();
        }

        global::Main.Interface.OpenProject thisproject;
        private void WinFrmLifecycleEvent_BrowserProjectEvent(global::Main.Interface.OpenProject project)
        {
            thisproject = project;
            (thisproject as OpenProject).OpenProject(this.Tv_filebrowser);
        }

        private void Tools_openfile_Click(object sender, EventArgs e)
        {
            if (Tv_filebrowser.SelectedNode == null)
                return;
            (thisproject as OpenProject).BrowserFileCodeFrmEvent += new BrowserFileCodeFrmHandler(FrmProject_BrowserFileCodeFrmEvent);
            (thisproject as OpenProject).BrowserFileCode(this.Tv_filebrowser.SelectedNode.Tag);

        }

        void FrmProject_BrowserFileCodeFrmEvent(WeifenLuo.WinFormsUI.Docking.DockContent content)
        {
            WinFrmLifecycleEvent.OnViewCodeFrmEvent(content);
        }

        private void Tv_filebrowser_DoubleClick(object sender, EventArgs e)
        {
            if (Tv_filebrowser.SelectedNode.Nodes.Count > 0)
                return;
            (thisproject as OpenProject).BrowserFileCodeFrmEvent += new BrowserFileCodeFrmHandler(FrmProject_BrowserFileCodeFrmEvent);
            (thisproject as OpenProject).BrowserFileCode(this.Tv_filebrowser.SelectedNode.Tag);
        }

        private void Tool_lookup_Click(object sender, EventArgs e)
        {
            if (Tv_filebrowser.Nodes.Count <= 0)
                return;
            (thisproject as OpenProject).Lookup(Tv_filebrowser);
        }

        private void Tools_openfiledir_Click(object sender, EventArgs e)
        {
            if (Tv_filebrowser.Nodes.Count <= 0)
                return;
            (thisproject as OpenProject).OpenFileDir(Tv_filebrowser.SelectedNode.Tag);
        }

        private void Tools_property_Click(object sender, EventArgs e)
        {
            WinFrmLifecycleEvent.OnDisplayProjectInfoEvent(Tv_filebrowser.SelectedNode.Tag);
        }
    }
}
