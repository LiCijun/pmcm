using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SetSN
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
         //   if (!AppInstance())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form_Main());
            }
        }

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        private const int WS_SHOWNORMAL = 1; 
        public static bool AppInstance()
        {
            System.Diagnostics.Process[] MyProcesses = System.Diagnostics.Process.GetProcesses();
            int i = 0;
            foreach (System.Diagnostics.Process MyProcess in MyProcesses)
            {
                if (MyProcess.ProcessName == System.Diagnostics.Process.GetCurrentProcess().ProcessName)
                {
                    SetForegroundWindow(MyProcess.MainWindowHandle); 
                    i++;
                }
            }
            return (i > 1) ? true : false;
        }
    }
}
