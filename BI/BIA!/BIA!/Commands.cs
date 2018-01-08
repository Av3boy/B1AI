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
                Program.reconized = "";

                while (heyb1 == false)
                {

                    if (Program.reconized == "hey mate")
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
                    if(!String.IsNullOrEmpty(Program.reconized))
                        continue;
                }

                switch (Program.reconized)
                {
                    case "google":
                        Search.google();
                        break;

                    case "mayday mayday":
                    case "chromosome alert":
                        ChromosomeAlert.player();
                        break;

                    case "change username":
                        string path = @"C:\Users\" + Program.GetUsername + @"\B1config.txt";
                        File.Delete(path);
                        Console.Clear();
                        Welcome.welcome();
                        break;

                    case "clear":
                        Console.Clear();
                        Program.Main();
                        break;

                    case "set school day alarm":
                        alarmclock.Start();
                        AlarmClock.SetSchoolAlarm();
                        break;

                    case "shut the fuck up":
                        Program.speaker.Speak("No, you can go fuck yourself");
                        break;

                    case "test":
                            Console.WriteLine("xxx");
                        break;

                    case "youtube":
                        Search.youtube();
                        break;

                    case "What can you do":
                        Console.WriteLine();
                        PrintCommands.commands();
                        break;

                    case "i am the admin":
                        AdminIdentity.check();
                        break;

                    case "shutdown my workstation":
                        if (Program.admin == true)
                        {
                            Process.Start("shutdown", "/s /t 1");
                            Environment.Exit(0);
                        }
                        if (Program.admin == false)
                            Program.speaker.Speak("I am sorry, but you do not have admin permissions. Operation aborted.");
                        break;                 

                    case "version":
                        Console.WriteLine("V 0.3.2");
                        break;

                    case "quit":
                        Quit.quit();
                        break;

                    case "pornoo":
                        Search.Pornoo();
                        break;

                    case "time":
                        Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                        Program.speaker.Speak(DateTime.Now.ToString("h:mm:ss tt"));
                        break;

                    case "calculator":
                        Calculator.calculator();
                        break;

                    case "change language":
                        Language.LanguageSelector();
                        break;

                    case "wake me up at morning":
                        alarmclock.Start();
                        AlarmClock.SetCustomAlarm();
                        break;

                    default:
                        if (Program.helloB1.Contains(Program.reconized, StringComparer.OrdinalIgnoreCase))
                        {
                            Hey.hey();
                            break;
                        }

                        else
                        {
                            Console.WriteLine("I am sorry, but im not be able to execute that command");
                            Program.speaker.Speak("I am sorry, but im not be able to execute that command");
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
            string CurrentTime = DateTime.Now.ToString("h:mm:ss");
            if (Program.AlarmTime == CurrentTime)
                AlarmClock.alarm();
        }
    }
}
