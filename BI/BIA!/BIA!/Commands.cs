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
            alarmclock.Start();
            Boolean quitNow = false;
            Boolean heyb1 = false;
            
            while (!quitNow)
            {

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
                        Google.google();
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

                    case "shut the fuck up":
                        Program.speaker.Speak("No, you can go fuck yourself");
                        break;

                    case "test":
                            Console.WriteLine("xxx");
                        break;

                    case "youtube":
                        Youtube.youtube();
                        break;

                    case "What can you do":
                        Console.WriteLine();
                        PrintCommands.commands();
                        break;

                    case "i am the admin":
                        AdminIdentity.check();
                        break;

                    case "Shutdown my workstation":
                        Process.Start("shutdown", "/s /t 1");
                        Environment.Exit(0);
                        break;                 

                    case "version":
                        Console.WriteLine("V 0.2.2");
                        break;

                    case "quit":
                        Quit.quit();
                        break;

                    case "pornoo":
                        Porn.Pornoo();
                        break;

                    case "time":
                        Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                        Program.speaker.Speak(DateTime.Now.ToString("h:mm:ss tt"));
                        break;

                    case "cal":
                        Calculator.calculator();
                        break;

                    case "lan":
                        Language.LanguageSelector();
                        break;

                    default:
                        if (Program.helloB1.Contains(Program.reconized, StringComparer.OrdinalIgnoreCase))
                        {
                            Hey.hey();
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Unknown Command " + Program.reconized);
                            Program.speaker.Speak("Unknown Command " + Program.reconized);
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
            Console.WriteLine(DateTime.Now.ToString("h:mm:ss"));
            string CurrentTime = DateTime.Now.ToString("h:mm:ss");
            string AlarmTime = "3:53:00";
            if (AlarmTime == CurrentTime)
                AlarmClock.alarm();
        }

    }
}
