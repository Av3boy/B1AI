using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Timers;

namespace BIA_
{
    class Commands
    {
        public static void commands()
        {

            Timer alarmclock = new Timer();
            alarmclock.Interval = 1000;
            alarmclock.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            Boolean quitNow = false;
            Boolean heyb1 = false;

            while (!quitNow)
            {

                while (heyb1 == false)
                {

                    if (Program.reconized == "Hey mate" && Program.wrongpassword == true)
                    {
                        Program.speaker.Speak("Admin identity cannot be confirmed, please enter password !");

                        if (Program.reconized == "Everything is fine now, you can stop that")
                        {
                            Program.reconized = "";
                            Program.wrongpassword = false;

                        }
                    }

                    if (Program.reconized == "Hey mate")
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
                        ChromosomeAlert.player();
                        break;

                    case "Change username":
                        string path = @"C:\Users\" + Program.GetUsername + @"\B1config.txt";
                        File.Delete(path);
                        Console.Clear();
                        Welcome.welcome();
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
                        Console.WriteLine();
                        PrintCommands.commands();
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
                        Quit.quit();
                        break;

                    case "Pornoo":
                        Search.Pornoo();
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
                            Program.adminpasswordstring = "";
                        }
                        break;

                    case "What time is it":
                        Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                        Program.speaker.Speak(DateTime.Now.ToString("h:mm:ss tt"));
                        break;

                    case "Open calculator":
                        Calculator.calculator();
                        break;

                    case "Change language":
                        Language.LanguageSelector();
                        break;

                    case "Wake me up at morning":
                        alarmclock.Start();
                        AlarmClock.SetCustomAlarm();
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
                        if (Program.helloB1.Contains(Program.reconized, StringComparer.OrdinalIgnoreCase))
                        {
                            Hey.hey();
                            break;
                        }

                        else
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
            if (Program.AlarmTime == Program.CurrentTime)
                AlarmClock.alarm();
        }
    }
}
