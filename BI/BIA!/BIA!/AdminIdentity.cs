using System;
using System.Linq;
using System.Timers;

namespace BIA_
{
    class AdminIdentity
    {
        public static void check()

        {
            Program.speaker.Speak("Can you prove your identity?");
            Program.reconized = "";

            while(!Program.AdminIdentity)
            {
                if(Program.Yes.Contains(Program.reconized))
                {
                    Program.reconized = "";
                    Program.speaker.Speak("You have 5 seconds to prove your identity before system lock you out permanently.");
                    Timers.lockout.Start();

                    while(!Program.AdminIdentity)
                    {
                        if (Program.reconized == "Alex is gay")
                        {
                            Program.reconized = "";
                            Program.AdminIdentity = true;
                            Timers.lockout.Stop();
                            Program.speaker.Speak("Identity confirmed, welcome back root.");
                            Program.admin = true;
                            Commands.commands();
                        }
                    }
                }
                else if (Program.No.Contains(Program.reconized))
                {
                    Program.speaker.Speak("Okay, operation aborted.");
                    Commands.commands();
                }
            }
        }
        public static void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            Timers.lockout.Stop();
            Program.WrongPassword = true;
            Program.AdminIdentity = false;
            Program.reconized = "";
            Program.speaker.Speak("Ídentity cannot be confirmed");
            Commands.commands();
        }
    }
}

