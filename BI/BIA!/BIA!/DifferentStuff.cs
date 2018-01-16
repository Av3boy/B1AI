using System;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;

namespace BIA_
{
    class DifferentStuff
    {
        public static void ChromosomeAlert()
        {
            Program.reconized = "";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Alert.wav";
            player.Play();
            Program.speaker.Speak("Chromosome alert");
            Program.speaker.Speak("evacuate the building immediately, this is not a test");
            Program.speaker.Speak("Chromosome alert");
            Program.speaker.Speak("evacuate the building immediately, this is not a test");
            Program.speaker.Speak("Chromosome alert");
            Program.speaker.Speak("evacuate the building immediately, this is not a test");
            Program.speaker.Speak("Chromosome alert");
            Program.speaker.Speak("evacuate the building immediately, this is not a test");
            Program.speaker.Speak("Chromosome alert");
            Program.speaker.Speak("evacuate the building immediately, this is not a test");
            Program.speaker.Speak("Chromosome alert");
            Program.speaker.Speak("evacuate the building immediately, this is not a test");
            Program.speaker.Speak("Chromosome alert");
            Program.speaker.Speak("evacuate the building immediately, this is not a test");
            player.Stop();
            Commands.commands();
        }

        public static void LedControl()
        {

            bool ledISOn = false;

            if (Program.reconized == "Turn on led")
                ledISOn = true;

            if (Program.reconized == "Change led color")
                Program.speaker.Speak("What color do you want the led to be");

            if (Program.reconized == "")
            {

                Program.speaker.Speak("");
                var pattern = Console.ReadLine(); //vaihda patterni muuttuja esim switch/caseiin että käyttäjä voi vaihtaa ledi patternin esim breathingista paikkallaan pysyvään valoon

                //vaihda ledi patternia
                Program.speaker.Speak("Using: " + pattern);

            }
        }
        public static void calculator()
        {
            int first;
            int second;
            int answer;

            string operation;

            Program.speaker.Speak("give me the first number to calculate");
            first = Convert.ToInt32(Console.ReadLine());
            Program.speaker.Speak("now give me the operation");
            operation = Console.ReadLine();
            Program.speaker.Speak("now give me the second number");
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
                    Commands.commands();
                    break;

            }

        }
        public static void PrintCommands()
        {

            string[] commands = new string[9] { "'help' to show this dialog.", "'changeusername' to change username.",
                "'version' to show current version.",
                "'quit' to close application.", "'time' to show current time.",
                "'cal' to open calculator.", "'clear' to reset this window.",
                "'change the language' to change the language for the program.", "'led' to control the led" };

            foreach (string s in commands)
            {
                Console.WriteLine(s);
                Program.speaker.Speak(s);
            }

        }
        public static void quit()
        {
            bool quit = false;

            Program.speaker.Speak("Are you sure you want to close the program.");

            Program.reconized = "";

            while (quit == false)
            {
                if (Program.Yes.Contains(Program.reconized, StringComparer.OrdinalIgnoreCase))
                {
                    Environment.Exit(0);
                }
                else if (Program.No.Contains(Program.reconized, StringComparer.OrdinalIgnoreCase))
                {
                    Commands.commands();
                }
            }
        }
    }
    class Spotify
    {

        public static void NextSong()
        {
            string url = "http://unkn0wns.xyz/spotifynext.php";

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            string result = new StreamReader(response.GetResponseStream()).ReadToEnd();

            string result1 = new WebClient().DownloadString(url);
        }

        public static void PauseSong()
        {
            string url = "http://unkn0wns.xyz/spotifypause.php";

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            string result = new StreamReader(response.GetResponseStream()).ReadToEnd();

            string result1 = new WebClient().DownloadString(url);
        }

        public static void PreviousSong()
        {
            string url = "http://unkn0wns.xyz/spotifyprevious.php";

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            string result = new StreamReader(response.GetResponseStream()).ReadToEnd();

            string result1 = new WebClient().DownloadString(url);
        }
        public static void ResumePlay()
        {
            string url = "http://unkn0wns.xyz/spotifyresume.php";

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            string result = new StreamReader(response.GetResponseStream()).ReadToEnd();

            string result1 = new WebClient().DownloadString(url);
        }
    }
}
