using System;
using System.Diagnostics;

namespace B1AI
{
    class Search
    {
        public static void google()
        {

            Program.speaker.Speak("Enter search word: ");
            Console.WriteLine("Enter search word:");

            string searchInput = Program.reconized = "";
            Process.Start("https://www.google.fi/search?q=" + searchInput);

        }
        public static void Porn()
        {
            Console.WriteLine("Select Category:");
            Console.WriteLine("MILF");
            Console.WriteLine("Gay");
            Console.WriteLine("Lesbian");
            Console.WriteLine("BBC");
            Console.WriteLine("");
            string searchInput = Console.ReadLine();
            Process.Start("https://www.pornhub.com/video/search?search=" + searchInput);
        }
        public static void youtube()
        {

            Console.WriteLine("Enter search word:");

            string searchInput = Console.ReadLine();
            Process.Start("https://www.youtube.com/results?search_query=" + searchInput);


        }
    }
}
