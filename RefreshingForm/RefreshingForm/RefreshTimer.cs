using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshingForm
{
    internal static class RefreshTimer
    {
        internal static void Timer(int interval, bool isRandom, string processName)
        {
            System.Windows.Forms.Timer refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = GetInterval(interval, isRandom);
            refreshTimer.Tick += (object s, EventArgs a) => Refresh.RefreshBrowser(s, a, processName);
            refreshTimer.Enabled = true;
            refreshTimer.Start();
        }

        private static int GetInterval(int interval, bool isRandom)
        {
            if (!isRandom)
                return interval;

            Random rnd = new Random();
            return rnd.Next(60000, 270000);
        }

    }
}
