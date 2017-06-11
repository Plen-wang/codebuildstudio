using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.IO;
using System.Configuration;
using System.ComponentModel;

namespace ThempEdit.Come.Command
{
    /// <summary>
    /// 模板参照文件读写操作
    /// </summary>
    public class ReadThempMaster : ISynchronizeInvoke
    {
        Hashtable resulttb;
        private string masterpath = string.Empty;
        public ReadThempMaster()
        {
            masterpath = ConfigurationManager.AppSettings["CodeThempMasterPath"];
        }
        /// <summary>
        /// 获取模板参照文件列表
        /// </summary>
        /// <returns></returns>
        public Hashtable GetMasterFileList()
        {
            if (Directory.Exists(masterpath))
            {
                resulttb = new Hashtable();
                string[] dirlist = Directory.GetDirectories(masterpath);
                foreach (string str in dirlist)
                {
                    string[] filelist = Directory.GetFiles(str);
                    resulttb.Add(str, filelist);
                }
                return resulttb;
            }
            //抛出构件内部异常，让PlugManager构件管理中心记录下来
            throw new Main.Interface.ComeBaseModule.ComeRestException("路径字符串不存在", "模板编辑构件:ThempEdit.Come.dll，方法名称:GetMasterFileList");
        }

        #region ISynchronizeInvoke 成员

        public IAsyncResult BeginInvoke(Delegate method, object[] args)
        {
            throw new NotImplementedException();
        }

        public object EndInvoke(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public object Invoke(Delegate method, object[] args)
        {
            throw new NotImplementedException();
        }

        public bool InvokeRequired
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
