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
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Speech;


namespace BIA_
{
    class Program
    {
        public static SpeechSynthesizer speaker = new SpeechSynthesizer();
        public static string GetUsername = Environment.UserName;
        public static string logpath = @"C:\Users\" + GetUsername + @"\B1log.txt";
        public static string configpath = @"C:\Users\" + GetUsername + @"\B1config.txt";
        public static string Username;
        public static string[] helloB1 = { "HI B1", "HELLO B1", "HEY B1", "HI", "HEY", "HELLO", "Suhh" };

        Timer t = new Timer(TimerCallback, null, 0, 2000);
        
        public static void Main()
        {
           
            speaker.Rate = 1;
            speaker.Volume = 100;

            log();
            Commands();
            ListenForKeyWords();
        }

        public static void Welcome()
        {
            Thread.CurrentThread.IsBackground = true;
            if (!File.Exists(configpath))
            {

                Console.WriteLine("Hello! My name is B1, i am programmed to serve as an allpurpose program.");
                Console.WriteLine("How can i help? Type 'help' to see available commands.");
                Console.WriteLine("But first, i wan't to know your name: ");
                speaker.Speak("Hello! My name is B1, i am programmed to serve as an allpurpose program.");
                speaker.Speak("How can i help? Type 'help' to see available commands.");
                speaker.Speak("But first, i wan't to know your name: ");
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
                Console.WriteLine("Hello " + username + "! How i can help you today ?");
                Console.WriteLine("As you already know, type 'help' to see available commands.");
                speaker.Speak("Hello " + username + "! How i can help you today ?");
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
                        Program.speech();
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
                        speaker.Speak(DateTime.Now.ToString("h:mm:ss tt"));
                        break;

                    case "cal":
                        Calculator();
                        break;

                    default:
                        if (helloB1.Contains(command, StringComparer.OrdinalIgnoreCase))
                        {
                            Program.hey();
                            break;
                        }
                           
                        else
                            Console.WriteLine("Unknown Command " + command);
                            speaker.Speak("Unknown Command " + command);
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

            string[] commands = new string[7] { "'help' to show this dialog.", "'changeusername' to change username.", "'version' to show current version.",
                "'quit' to close application.", "'time' to show current time.", "'cal' to open calculator.", "'clear' to reset this window." };

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
        static void speech()
        {
            var speech = new SpeechRecognitionEngine();
            Grammar gr = new Grammar(new GrammarBuilder(new Choices("Hello")));

            try
            {
                speech.RequestRecognizerUpdate();
                speech.LoadGrammar(gr);
                speech.SpeechRecognized += reconized_voice;
                speech.SetInputToDefaultAudioDevice();
                speech.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            Console.ReadLine();
        }
        public static void reconized_voice(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine(e.Result.Text.ToString());
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
        public static void hey()
        {
            string Message1 = "";
            string Message2 = "";
            string username = File.ReadLines(configpath).First();
            Random random1 = new Random();
            string Hello1 = "Hey ";
            string Hello2 = "Hi ";
            string Hello3 = "Hello ";
            string Question1 = "! How are you doing?";
            string Question2 = "! How have you been?";
            string Question3 = "! How's everything?";
            string Question4 = "! How's it going?";
            string Question5 = "! What's going on?";
            string Question6 = "! What's new?";
            string Question7 = "! What's up?";
            string Question8 = "! Whassup?";
            string Question9 = "! What are you up to?";


            int randomNumber1 = random1.Next(0, 3);
            switch (randomNumber1)
            {
                case 0:
                    Message1 = Hello1;
                    break;

                case 1:
                    Message1 = Hello2;
                    break;
                case 2:
                    Message1 = Hello3;
                    break;
            }
            int randomNumber2 = random1.Next(0, 9);
            switch (randomNumber2)
            {
                case 0:
                    Message2 = Question1;
                    break;
                case 1:
                    Message2 = Question2;
                    break;
                case 2:
                    Message2 = Question3;
                    break;
                case 3:
                    Message2 = Question4;
                    break;
                case 4:
                    Message2 = Question5;
                    break;
                case 5:
                    Message2 = Question6;
                    break;

                case 6:
                    Message2 = Question7;
                    break;

                case 7:
                    Message2 = Question8;
                    break;

                case 8:
                    Message2 = Question9;
                    break;
            }

            Console.WriteLine(Message1 + username + Message2);
            speaker.Speak(Message1 + username + Message2);
        }
        public static void log()
        {

                using (var tw = new StreamWriter(logpath, true))
                {
                    tw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"));
                    tw.Close();
                    Console.Clear();
                    Welcome();
                }
          
        }
    }
}