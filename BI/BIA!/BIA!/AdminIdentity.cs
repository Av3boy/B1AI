using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace BIA_
{
    class AdminIdentity
    {
        public static void check()
        {

            Program.speaker.Speak("Can you prove your identity?");

            while (Program.adminpasswordstring == "")
            {
                if (Program.reconized == "Yes" || Program.reconized == "Yes i can" || Program.reconized == "Sure")
                {
                    Program.speaker.Speak("You have 5 seconds to prove your identity before system lock you out permanently.");
                    Program.lockout.Start();
                    while (String.IsNullOrEmpty(Program.adminpasswordstring))
                    {
                        if (Program.reconized == "Alex is gay")
                        {
                            Program.adminpasswordstring = "asd";
                            Program.lockout.Stop();
                            Program.speaker.Speak("Identity identified, welcome back root.");
                            Program.admin = true;
                            Commands.commands();
                        }
                        
                    }
                }

                if (Program.reconized == "No")
                {

                    Program.speaker.Speak("Okay, operation aborted.");
                    Commands.commands();

                }
            }            
        }

        public static void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            Program.speaker.Speak("Empty or incorrect password entered, system is going to full lockdown");
            Program.wrongpassword = true;
            Program.adminpasswordstring = "asd";
            Program.lockout.Stop();
        }
    }
}

