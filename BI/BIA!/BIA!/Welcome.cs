using System;
using System.IO;
using System.Linq;

namespace BIA_
{
    class Welcome
    {
        public static void welcome()
        {
            using (var tw = new StreamWriter(Program.logpath, true))
            {
                tw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"));
                tw.Close();
            }

            if (!File.Exists(Program.configpath))
            {

                Console.WriteLine("Hello! My name is B1, i am programmed to serve as an allpurpose program.");
                Console.WriteLine("How can i help? Type 'help' to see available commands.");
                Console.WriteLine("But first, i wan't to know your name: ");
                Program.speaker.SpeakAsync("Hello! My name is B1, i am programmed to serve as an allpurpose program.");
                Program.speaker.SpeakAsync("How can i help? Type 'help' to see available commands.");
                Program.speaker.SpeakAsync("But first, i wan't to know your name: ");
                Program.Username = Console.ReadLine();

                using (var tw = new StreamWriter(Program.configpath, true))
                {
                    tw.WriteLine(Program.Username);
                    tw.Close();
                    Console.Clear();
                }
            }

            if (File.Exists(Program.configpath))
            {
                Program.Username = File.ReadLines(Program.configpath).First();
                Console.WriteLine("Hello " + Program.Username+ "! How i can help you today ?");
                Console.WriteLine("As you already know, type 'help' to see available commands.");
                Program.speaker.SpeakAsync("Hello " + Program.Username + "! How can I help you today ?");
                Commands.commands();
            }
        }
    }
}
