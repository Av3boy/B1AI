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
            bool quit = false;

            Program.speaker.Speak("Are you sure you want to close the program.");

            Program.reconized = "";

            while (quit == false)
            {
                if (Program.reconized == "Yes")
                {
                    Environment.Exit(0);
                }
                else if (Program.reconized == "No")
                {
                    Commands.commands();
                }
            }
        }
    }
}