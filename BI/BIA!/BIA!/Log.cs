using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA_
{
    class Log
    {
        public static void log()
        {

            using (var tw = new StreamWriter(Program.logpath, true))
            {
                tw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"));
                tw.Close();
                Welcome.welcome();
            }

        }
    }
}
