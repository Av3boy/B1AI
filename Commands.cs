using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Timers;

namespace B1AI
{
    class Commands
    {
        public static void commands()
        {

            Timer alarmclock = new Timer();
            alarmclock.Interval = 1000;
            alarmclock.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            bool quitNow = false;
            bool heyb1 = false;

            while (!quitNow)
            {

                while(!heyb1)
                {

                    if (Program.Hey.Contains(Program.reconized) && Program.WrongPassword)
                    {
                        Program.reconized = "";
                        Program.speaker.Speak("Admin identity cannot be confirmed.");
                        AdminIdentity.check();
                    }

                    if (Program.Hey.Contains(Program.reconized) && !Program.WrongPassword)
                    {
                        Program.reconized = "";
                        heyb1 = true;
                        SoundPlayer player = new SoundPlayer();
                        player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\pop.wav";
                        player.Play();
                    }
                }

                while (String.IsNullOrEmpty(Program.reconized))
                {
                    if (!String.IsNullOrEmpty(Program.reconized))
                        continue;
                }

                switch (Program.reconized)
                {
                    case "Search from google":
                        Search.google();
                        break;

                    case "Chromosome alert":
                    case "I have some relationship people over here":
                        DifferentStuff.ChromosomeAlert();
                        break;

                    case "Change username":
                        File.Delete(Program.configpath);
                        Console.Clear();
                        Welcome.welcome();
                        break;

                    case "Who am i":
                    case "What is my name":
                        if (!Program.admin)
                        {
                            Program.speaker.Speak("I think your name is" + Program.Username);
                        }
                        else
                            Program.speaker.Speak("I think you are root");
                        break;

                    case "Clear console":
                        Console.Clear();
                        Welcome.welcome();
                        break;

                    case "Set school day alarm":
                        alarmclock.Start();
                        AlarmClock.SetSchoolAlarm();
                        break;

                    case "Shut the fuck up":
                        Program.speaker.Speak("No, you can go fuck yourself");
                        break;

                    case "Test":
                        Console.WriteLine("xxx");
                        break;

                    case "Search from youtube":
                        Search.youtube();
                        break;

                    case "What can you do":
                        DifferentStuff.PrintCommands();
                        break;

                    case "I am the admin":
                        AdminIdentity.check();
                        break;

                    case "Shutdown my workstation":
                        Workstation.shutdown();
                        break;

                    case "What is the current version":
                        Console.WriteLine("V 0.3.2");
                        Program.speaker.Speak("Version 0.3.2");
                        break;

                    case "Bye bye":
                    case "Exit the application":
                        DifferentStuff.quit();
                        break;

                    case "Search porn":
                        Search.Porn();
                        break;

                    case "Revoke admin permissions":
                        if (Program.admin == false)
                        {
                            Program.speaker.Speak("Command cannot be executed because your identity is not identified, operation aborted.");
                        }
                        if (Program.admin == true)
                        {
                            Program.speaker.Speak("Admin permissions revoked");
                            Program.admin = false;
                            Program.AdminIdentity = false;
                        }
                        break;

                    case "What time is it":
                        Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                        Program.speaker.Speak(DateTime.Now.ToString("h.mm tt"));
                        break;

                    case "Open calculator":
                        DifferentStuff.calculator();
                        break;

                    case "Change language":
                        Language.LanguageSelector();
                        break;

                    case "Wake me up at morning":
                        alarmclock.Start();
                        AlarmClock.SetCustomAlarm();
                        break;

                    case "Set school alarm":
                        alarmclock.Start();
                        AlarmClock.SetSchoolAlarm();
                        break;

                    case "Next song":
                        Spotify.NextSong();
                        break;

                    case "Show my current game stats":
                        Process.Start("http://eune.op.gg/summoner/userName=docstrac#");
                        break;

                    case "Previous song":
                        Spotify.PreviousSong();
                        break;

                    case "Stop music":
                        Spotify.PauseSong();
                        break;

                    case "Resume music":
                        Spotify.ResumePlay();
                        break;

                    default:
                        {
                            Console.WriteLine("I'm sorry, but i'm not able to execute that command");
                            Program.speaker.Speak("I'm sorry, but i'm not able to execute that command");
                            Program.reconized = "";
                            break;
                        }

                }
                if (!String.IsNullOrEmpty(Program.reconized))
                {
                    Program.reconized = "";
                }

                heyb1 = false;
            }
        }

        public static void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            if (Program.AlarmTime == DateTime.Now.ToString("h:mm:ss"))
                AlarmClock.alarm();
        }
    }
}
