using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA_
{
    class Workstation
    {

        public static void shutdown()
        {
            if (Program.admin == true)
            {
                Process.Start("shutdown", "/s /t 1");
                Environment.Exit(0);
            }
            if (Program.admin == false)
            {
                Program.speaker.Speak("I am sorry, but you are not confirmed your identity.");
                Program.speaker.Speak("Do you want confirm your identity now ?");

                while(Program.admin == false)
                {
                    if (Program.reconized == "Yes")
                    {
                        Program.reconized = "";
                        AdminIdentity.check();
                    }

                    if(Program.reconized == "No")
                    {
                        Program.speaker.Speak("Okay, Operation aborted.");
                        Program.reconized = "";
                        Commands.commands();
                    }

                }

            }

        }
    }
}
