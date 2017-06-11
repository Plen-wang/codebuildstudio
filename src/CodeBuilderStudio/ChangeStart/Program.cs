using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ChangeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("检测FastExpress.net.exe............");
            Process[] proc = Process.GetProcessesByName("FastExpress.net");
            if (proc.Length == 0)
                return;
            Console.WriteLine("相关进程：" + proc.Length);
            Console.WriteLine("关闭FastExpress.net.exe进程");
            foreach (Process p in proc)
            {
                p.Kill();
            }
            Console.WriteLine("启动FastExpress.net.exe进程");
            Process.Start("FastExpress.net.exe");
        }
    }
}
