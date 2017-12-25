using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Threading;
using System.Diagnostics;
//using HtmlAgilityPack;
=======
using System.Threading.Tasks;
>>>>>>> 0fd1e395d30517cd993597918b7ef9adc483b173
using System.Net;
using System.Media;

namespace BIA_
{
    class Program
    {

            public static string GetUsername = Environment.UserName;
            public static string configpath = @"C:\Users\" + GetUsername + @"\B1config.txt";

        public static void Main()
        {

            Welcome();
            ConnectToInternet();
            Commands();

        }

        public static void Welcome()
        {
            if (!File.Exists(configpath))
            {

                Console.WriteLine("Hello! My name is B1, i am programmed to serve as an allpurpose program.");
                Console.WriteLine("How can i help? Type /HELP to see available commands.");
                Console.WriteLine("But first, i wan't to know your name: ");

                string usernametosave = Console.ReadLine();
                using (var tw = new StreamWriter(configpath, true))
                {
                    tw.WriteLine(usernametosave);
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
        private static void ConnectToInternet()
        {

            throw new NotImplementedException();

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
                    case "/changeusername":
                        string path = @"C:\Users\" + GetUsername + @"\B1config.txt";
                        File.Delete(path);
                        Console.Clear();
                        Program.Welcome();
                        break;

                    case "/clear":
                        Console.Clear();
                        Program.Main();
                        break;

                    case "/yt":
                        Program.youtube();
                        break;

                    case "/help":
                        Console.WriteLine();
                        Program.commands();
                        break;

                    case "/version":
                        Console.WriteLine("V 0.1.0");
                        break;

                    case "/quit":
                        Quit();
                        break;

                    case "/time":
                        Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                        break;

                    case "/cal":
                        Calculator();
                        break;

                    default:
                        Console.WriteLine("Unknown Command " + command);
                        break;
                }
            }

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

            string ytSearch = Console.ReadLine();

            Console.WriteLine("Enter search word: ");


        }

        public void google()
        {

            string searchInput = Console.ReadLine();

            Console.WriteLine("Enter search word");

        }

    }
}