using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net;
using System.Media;
using HtmlAgilityPack;

namespace BIA_
{
    class Program
    {
        public static string GetUsername = Environment.UserName;
        public static string configpath = @"C:\Users\" + GetUsername + @"\B1config.txt";
        public static string Username;
        public static string[] helloB1 = { "HI B1", "HELLO B1"};

        Timer t = new Timer(TimerCallback, null, 0, 2000);

        public static void Main()
        {

            Welcome();
            Commands();
            ListenForKeyWords();
        }

        public static void Welcome()
        {
            if (!File.Exists(configpath))
            {

                Console.WriteLine("Hello! My name is B1, i am programmed to serve as an allpurpose program.");
                Console.WriteLine("How can i help? Type 'help' to see available commands.");
                Console.WriteLine("But first, i wan't to know your name: ");
                Username = Console.ReadLine();

                using (var tw = new StreamWriter(configpath, true))
                {
                    tw.WriteLine(Username);
                    tw.Close();
                    Console.Clear();
                    Program.Main();

                }
            }

            if (File.Exists(configpath))
            {
                string username = File.ReadLines(configpath).First();
                Console.WriteLine("Hello " + username + "! How i can help today ?");
                Console.WriteLine("As you already know, type /help to see available commands.");
                Commands();
            }
        }

        public static void Commands()
        {

            String command;
            Boolean quitNow = false;

            while (!quitNow)
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "google":
                        Program.google();
                        break;

                    case "changeusername":
                        string path = @"C:\Users\" + GetUsername + @"\B1config.txt";
                        File.Delete(path);
                        Console.Clear();
                        Program.Welcome();
                        break;

                    case "clear":
                        Console.Clear();
                        Program.Main();
                        break;

                    case "test":
                        Program.asd();
                        break;

                    case "youtube":
                        Program.youtube();
                        break;

                    case "help":
                        Console.WriteLine();
                        Program.commands();
                        break;

                    case "version":
                        Console.WriteLine("V 0.1.0");
                        break;

                    case "quit":
                        Quit();
                        break;

                    case "pornoo":
                        Pornoo();
                        break;

                    case "time":
                        Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                        break;

                    case "cal":
                        Calculator();
                        break;

                    default:
                        if (helloB1.Contains(command, StringComparer.OrdinalIgnoreCase))
                                Console.WriteLine("Hello " + Username + "! How's it going ?");
                        else
                                Console.WriteLine("Unknown Command " + command);
                        break;
                    
                }
                
            }

        }
        private static void Pornoo()
        {
            Console.WriteLine("Select Category:");
            Console.WriteLine("MILF");
            Console.WriteLine("Gay");
            Console.WriteLine("Lesbian");
            Console.WriteLine("");

            string searchInput = Console.ReadLine();
            Process.Start("https://www.youtube.com/results?search_query=" + searchInput);
        }

        private static void ListenForKeyWords()
        {
            string[] keyWords = new string[1] { "Hey B1" };
            foreach (string s in keyWords)
            {
                Console.WriteLine(s);
            }

        }

        private static void TimerCallback(Object o)
        {
           
            Console.WriteLine("pillu");
            // Force a garbage collection to occur for this demo.
            GC.Collect();
        }

        public static void Quit()
        {
            Console.WriteLine("Are you sure you want to close the program. Press Y to close, Press N to cancel.");

            if (Console.ReadKey(true).Key == ConsoleKey.Y)
                Environment.Exit(0);

            else if (Console.ReadKey(true).Key == ConsoleKey.N)
            {

                Program.Main();

            }
        }

        public static void commands()
        {
            string[] commands = new string[7] { "/help to show this dialog.", "/changeusername to change username.", "/version to show current version.",
                "/quit to close application.", "/time to show current time.", "/cal to open calculator.", "/clear to reset this window." };
            foreach (string s in commands)
            {
                Console.WriteLine(s);
            }

        }

        public static void Calculator()
        {
            int first;
            int second;
            int answer;

            string operation;

            first = Convert.ToInt32(Console.ReadLine());
            operation = Console.ReadLine();
            second = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {

                case "/":
                    answer = first / second;
                    Console.WriteLine(first + " / " + second + " = " + answer);
                    break;

                case "*":
                    answer = first * second;
                    Console.WriteLine(first + " * " + second + " = " + answer);
                    break;

                case "+":
                    answer = first + second;
                    Console.WriteLine(first + " + " + second + " = " + answer);
                    break;

                case "-":
                    answer = first - second;
                    Console.WriteLine(first + " - " + second + " = " + answer);
                    break;

                default:
                    Console.WriteLine("Unknown Command " + operation);
                    Commands();
                    break;

            }

        }

        public static void youtube()
        {

            Console.WriteLine("Enter search word:");

            string searchInput = Console.ReadLine();
            Process.Start("https://www.youtube.com/results?search_query=" + searchInput);


        }

        public static void google()
        {

            Console.WriteLine("Enter search word:");

            string searchInput = Console.ReadLine();
            Process.Start("https://www.google.fi/search?q=" + searchInput);

        }
        public static void asd()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("https://www.youtube.com/results?search_query=asd");
            HtmlNode[] nodes = document.DocumentNode.SelectNodes("//a/slot").ToArray();
            foreach (HtmlNode item in nodes)
            {
                Console.WriteLine(item.InnerHtml);
            }
        }
    }
}