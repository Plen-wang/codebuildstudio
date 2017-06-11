/*
 *author:南京.王清培
 *coding time:2011.7.11
 *copyright:快捷速递
 *function:该类负责打开解决方案，包括对目录的递归获取等；
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace OpenProject.Come.Command
{
    /// <summary>
    /// open "*.sln" file directory 
    /// </summary>
    public static class OpenFileDirectory
    {
        /// <summary>
        /// entry point ,parameter "*.sln" from path 
        /// </summary>
        /// <param name="filenamepath">filepath</param>
        public static Module.M_DomResolvent OpenDirectory(string filenamepath)
        {
            Module.M_DomResolvent resolvent = new OpenProject.Come.Module.M_DomResolvent();
            resolvent.FileName = Path.GetFileNameWithoutExtension(filenamepath);//set resolvent info
            resolvent.FilePath = filenamepath;

            List<Module.M_DomProject> projectlist = new List<OpenProject.Come.Module.M_DomProject>();


            string[] projectdir = Directory.GetDirectories(Path.GetDirectoryName(filenamepath));//get project dir list
            XmlDocument document;
            foreach (string sub in projectdir)
            {
                string projectname = sub.Substring(sub.LastIndexOf("\\") + 1) + ".csproj";//
                string projectpath = Path.Combine(sub, projectname);
                if (!File.Exists(projectpath))
                    continue;

                document = new XmlDocument();
                document.Load(projectpath);//get project "*.xml" stream

                Module.M_DomProject project = GetProject(document.DocumentElement, Path.GetDirectoryName(projectpath));
                project.FileName = Path.GetFileNameWithoutExtension(projectpath);
                project.FilePath = projectpath;
                projectlist.Add(project);
            }
            resolvent.ProjectCollection = projectlist;
            return resolvent;

        }
        //get project 
        private static Module.M_DomProject GetProject(XmlNode documentelement, string filenamepath)
        {
            XmlNode item = documentelement.ChildNodes[0];
            Module.M_DomProject resultproject = new OpenProject.Come.Module.M_DomProject();
            foreach (XmlNode node in item.ChildNodes)
            {
                switch (node.Name)
                {
                    case "ProductVersion": resultproject.ProductVersion = node.InnerText; break;
                    case "SchemaVersion": resultproject.SchemaVersion = node.InnerText; break;
                    case "ProjectGuid": resultproject.ProjectGuid = node.InnerText; break;
                    case "OutputType": resultproject.OutputType = node.InnerText; break;
                    case "RootNamespace": resultproject.RootNameSpace = node.InnerText; break;
                    case "AssemblyName": resultproject.AssemblyName = node.InnerText; break;
                }
            }
            GetReflectionAssemblyList(documentelement, resultproject);//get reflection assmbly list
            string[] dirlist = Directory.GetDirectories(filenamepath);
            if (dirlist.Length >= 0)//if project is directory 
            {
                Module.M_DomDirectory dir = new OpenProject.Come.Module.M_DomDirectory();
                GetDirectoryCsFileList(filenamepath, dir);
                foreach (Module.M_DomCs cs in dir.CsFileCollection)
                {
                    resultproject.CsFileCollection.Add(cs);
                }
                resultproject._dir.Add(dir);
            }
            return resultproject;
        }
        //get project reflection info
        private static void GetReflectionAssemblyList(XmlNode documentelement, Module.M_DomProject proj)
        {
            XmlNode item = documentelement.ChildNodes[3];//reflection assembly list
            foreach (XmlNode node in item.ChildNodes)
            {
                string[] sub = node.Attributes["Include"].Value.Split(',');
                if (sub.Length > 0)
                    proj._reflection.Add(sub[0]);
            }
        }
        //recursion get directory info 
        private static void GetDirectoryCsFileList(string formDirectory, Module.M_DomDirectory dirdom)
        {
            if (Directory.Exists(formDirectory))
            {
                string[] directory = Directory.GetDirectories(formDirectory);
                if (directory.Length > 0)
                {
                    foreach (string path in directory)//foreach current directory list
                    {
                        if (Path.GetFileNameWithoutExtension(path) == "obj" || (Path.GetFileNameWithoutExtension(path) == "bin"))
                            continue;


                        Module.M_DomDirectory dir = new OpenProject.Come.Module.M_DomDirectory();
                        dir.FileName = Path.GetFileNameWithoutExtension(path);
                        dir.FilePath = path;

                        if (Path.GetFileNameWithoutExtension(path) == "Properties")
                            dir.DirectoryType = OpenProject.Come.Module.DirType.Propertties;//file path is properties

                        dirdom.DirCollection.Add(dir);//would current directory add directory collection 
                        GetDirectoryCsFileList(path, dir);
                        //current get files 
                        List<string> files = new List<string>();
                        files.AddRange(Directory.GetFiles(path));//get current path file list
                        for (int index = 0; index < files.Count; index++)
                        {
                            if (Path.GetExtension(files[index]) == ".csproj")
                                files.RemoveAt(index);
                        }

                        if (files.Count > 0)
                        {
                            files.Sort();//element sort.employ element indent
                            for (int i = 0; i < files.Count; )
                            {
                                if ((i + 2) < files.Count)
                                {
                                    string filename = Path.GetFileName(files[i]).Split('.')[0];
                                    string filename2 = Path.GetFileName(files[i + 1]).Split('.')[0];
                                    string filename3 = Path.GetFileName(files[i + 2]).Split('.')[0];
                                    if ((filename == filename2) && (filename2 == filename3))//is design type file
                                    {
                                        Module.M_DomCs csdom = new OpenProject.Come.Module.M_DomCs();
                                        csdom.FileName = Path.GetFileName(files[i]);
                                        csdom.FilePath = files[i];
                                        SetDesignFileIco(csdom, Path.GetExtension(files[i]), Path.GetFileName(files[i + 1]), Path.GetFileName(files[i + 2]));
                                        dir.CsFileCollection.Add(csdom);
                                        files.RemoveAt(i + 2);
                                        files.RemoveAt(i + 1);
                                        files.RemoveAt(i);
                                        continue;
                                    }
                                }
                                Module.M_DomCs cs = new OpenProject.Come.Module.M_DomCs();
                                cs.FileName = Path.GetFileName(files[i]);
                                cs.FilePath = files[i];
                                SetFileIco(cs, Path.GetExtension(files[i]));
                                dir.CsFileCollection.Add(cs);
                                i++;
                            }
                        }
                    }
                    List<string> filess = new List<string>();
                    filess.AddRange(Directory.GetFiles(formDirectory));//get current path file list
                    for (int index = 0; index < filess.Count; index++)
                    {
                        if (Path.GetExtension(filess[index]) == ".csproj")
                            filess.RemoveAt(index);
                    }
                    if (filess.Count > 0)
                    {
                        filess.Sort();//element sort.employ element indent
                        for (int i = 0; i < filess.Count; )
                        {
                            if ((i + 2) < filess.Count)
                            {
                                string filename = Path.GetFileName(filess[i]).Split('.')[0];
                                string filename2 = Path.GetFileName(filess[i + 1]).Split('.')[0];
                                string filename3 = Path.GetFileName(filess[i + 2]).Split('.')[0];
                                if ((filename == filename2) && (filename2 == filename3))//is design type file
                                {
                                    Module.M_DomCs csdom = new OpenProject.Come.Module.M_DomCs();
                                    csdom.FileName = Path.GetFileName(filess[i]);
                                    csdom.FilePath = filess[i];
                                    SetDesignFileIco(csdom, Path.GetExtension(filess[i]), Path.GetFileName(filess[i + 1]), Path.GetFileName(filess[i + 2]));
                                    dirdom.CsFileCollection.Add(csdom);
                                    filess.RemoveAt(i + 2);
                                    filess.RemoveAt(i + 1);
                                    filess.RemoveAt(i);
                                    continue;
                                }
                            }
                            Module.M_DomCs cs = new OpenProject.Come.Module.M_DomCs();
                            cs.FileName = Path.GetFileName(filess[i]);
                            cs.FilePath = filess[i];
                            SetFileIco(cs, Path.GetExtension(filess[i]));
                            dirdom.CsFileCollection.Add(cs);
                            i++;
                        }
                    }
                }
            }
        }
        //set file ico
        private static void SetFileIco(Module.M_DomCs cs, string extenision)
        {
            switch (extenision)
            {
                case ".png": cs.IsType = OpenProject.Come.Module.CsType.img; break;
                case ".img": cs.IsType = OpenProject.Come.Module.CsType.img; break;
                case ".gif": cs.IsType = OpenProject.Come.Module.CsType.img; break;
                case ".jpg": cs.IsType = OpenProject.Come.Module.CsType.img; break;
                case ".html": cs.IsType = OpenProject.Come.Module.CsType.html; break;
                case ".config": cs.IsType = OpenProject.Come.Module.CsType.config; break;
                case ".cs": cs.IsType = OpenProject.Come.Module.CsType.Cs; break;
                case ".js": cs.IsType = OpenProject.Come.Module.CsType.js; break;
                case ".css": cs.IsType = OpenProject.Come.Module.CsType.css; break;
                case ".resx": cs.IsType = OpenProject.Come.Module.CsType.resource; break;
                case ".disco": cs.IsType = OpenProject.Come.Module.CsType.disco; break;
                case ".wsdl": cs.IsType = OpenProject.Come.Module.CsType.wsdl; break;
                case ".map": cs.IsType = OpenProject.Come.Module.CsType.map; break;
                case ".settings": cs.IsType = OpenProject.Come.Module.CsType.settings; break;
                case ".ico": cs.IsType = OpenProject.Come.Module.CsType.img; break;
                default: cs.IsType = OpenProject.Come.Module.CsType.defaults; break;

            }
        }
        //set design file group 
        private static void SetDesignFileIco(Module.M_DomCs cs, string extenision, params string[] filename)
        {
            switch (extenision)
            {
                case ".cs":
                    {
                        cs.IsType = OpenProject.Come.Module.CsType.winform;//winform design type file
                        foreach (string s in filename)
                        {
                            Module.M_DomCs csdom = new OpenProject.Come.Module.M_DomCs();
                            csdom.FileName = s;
                            csdom.IsType = OpenProject.Come.Module.CsType.design;//design type file
                            cs._cslist.Add(csdom);
                        }
                        break;
                    }
                case ".aspx":
                    {
                        cs.IsType = OpenProject.Come.Module.CsType.aspx;//asp.net page type file
                        foreach (string s in filename)
                        {
                            Module.M_DomCs csdom = new OpenProject.Come.Module.M_DomCs();
                            csdom.FileName = s;
                            csdom.IsType = OpenProject.Come.Module.CsType.design;//design type file
                            cs._cslist.Add(csdom);
                        }

                        break;
                    }
            }
        }
    }
}