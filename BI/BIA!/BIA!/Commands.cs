using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;

namespace BIA_
{
    class Commands
    {
        public static void commands()
        {

            Boolean quitNow = false;
            Boolean heyb1 = false;

            int resetCounter = 0;
            
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
                        resetCounter += 1;
                    }

                    if(resetCounter == 20)
                    {

                        Program.reconized = "";

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
                        Console.WriteLine("V 0.1.1");
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
    }
}
