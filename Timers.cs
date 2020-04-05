using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace B1AI
{
    class Timers
    {
        public static Timer lockout = new Timer();
        public static Timer CurrentTimeTimer = new Timer();

        static bool RunOnce = false;

        public static void AtStartup()
        {
            lockout.Interval = 5000;
            lockout.Elapsed += new ElapsedEventHandler(AdminIdentity.DisplayTimeEvent);

            if(RunOnce == false)
            {
                CurrentTimeTimer.Interval = 1000;
                CurrentTimeTimer.Elapsed += new ElapsedEventHandler(GetTime);
                CurrentTimeTimer.Start();
            }
        }
        public static void GetTime(object source, ElapsedEventArgs e)
        {
            //Console.WriteLine(DateTime.Now.ToString("h:mm:ss"));
        }
    }
}
