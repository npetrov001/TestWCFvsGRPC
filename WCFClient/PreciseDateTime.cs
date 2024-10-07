using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    internal class PreciseDateTime
    {
        // using DateTime.Now resulted in many many log events with the same timestamp.
        // use static variables in case there are many instances of this class in use in the same program
        // (that way they will all be in sync)
        private static readonly Stopwatch myStopwatch = new Stopwatch();
        private static System.DateTime myStopwatchStartTime;

        static PreciseDateTime()
        {
            Reset();

            try
            {
                // In case the system clock gets updated
                Microsoft.Win32.SystemEvents.TimeChanged += SystemEvents_TimeChanged;
            }
            catch (Exception)
            {
            }
        }

        static void SystemEvents_TimeChanged(object sender, EventArgs e)
        {
            Reset();
        }

        // SystemEvents.TimeChanged can be slow to fire (3 secs), so allow forcing of reset
        public static void Reset()
        {
            myStopwatchStartTime = System.DateTime.Now;
            myStopwatch.Restart();
        }

        public static System.DateTime Now
        {
            get { return myStopwatchStartTime.Add(myStopwatch.Elapsed); }
        }
    }
}
