using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BIA_
{
    class Welcome
    {
        public static void welcome()
        {
            Thread.CurrentThread.IsBackground = true;
            if (!File.Exists(Program.configpath))
            {

                Console.WriteLine("Hello! My name is B1, i am programmed to serve as an allpurpose program.");
                Console.WriteLine("How can i help? Type 'help' to see available commands.");
                Console.WriteLine("But first, i wan't to know your name: ");
                Program.speaker.Speak("Hello! My name is B1, i am programmed to serve as an allpurpose program.");
                Program.speaker.Speak("How can i help? Type 'help' to see available commands.");
                Program.speaker.Speak("But first, i wan't to know your name: ");
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
                string username = File.ReadLines(Program.configpath).First();
                Console.WriteLine("Hello " + username + "! How i can help you today ?");
                Console.WriteLine("As you already know, type 'help' to see available commands.");
                Program.speaker.Speak("Hello " + username + "! How i can help you today ?");
                Commands.commands();
            }
        }
    }
}
