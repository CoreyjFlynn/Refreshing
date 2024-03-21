using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RefreshingForm
{
    internal static class Refresh
    {
        internal static void RefreshBrowser(Object myObject, EventArgs myEventArgs, string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);

            foreach (Process proc in processes)
            {
                RefreshingForm.SetForegroundWindow(proc.MainWindowHandle);
                SendKeys.SendWait("{F5}");
            }
        }
    }
}
