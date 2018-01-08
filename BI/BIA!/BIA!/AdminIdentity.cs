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
            Timer lockout = new Timer();
            lockout.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            lockout.Interval = 5000;
            Boolean adminpassword = false;

            string adminpasswordstring = "";

            Program.speaker.Speak("Can you prove your identity?");

            while (adminpassword == false)
            {
                if (Program.reconized == "yes" || Program.reconized == "yes i can" || Program.reconized == "sure")
                {
                    Program.speaker.Speak("You have 5 seconds to prove your identity before system lock you out permanently.");
                    lockout.Start();
                    while (String.IsNullOrEmpty(adminpasswordstring))
                    {
                        if (Program.reconized == "123")
                        {
                            lockout.Stop();
                            Program.speaker.Speak("Hello root! Admin permissions granted.");
                            Program.admin = true;
                            adminpassword = true;
                            Commands.commands();
                        }
                        
                    }
                }

                if (Program.reconized == "no")
                {

                    Program.speaker.Speak("Okay, operation aborted.");
                    Commands.commands();

                }
            }            
        }

        public static void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            Program.speaker.Speak("Empty or incorrect password entered, system is going to full lockdown");
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Alert.wav";
            player.Play();
        }
    }
}

