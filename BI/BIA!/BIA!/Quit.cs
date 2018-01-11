using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA_
{
    class Quit
    {
        public static void quit()
        {

            Program.speaker.Speak("Are you sure you want to close the program.");

            Program.reconized = "";

            while (Program.reconized == "")
            {
                if (Program.reconized == "Yes")
                {
                    Environment.Exit(0);
                }

                else if(Program.reconized == "No")
                {
                    Program.Main();
                }
            }
        }
    }
}
