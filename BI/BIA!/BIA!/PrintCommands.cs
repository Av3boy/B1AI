using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA_
{
    class PrintCommands
    {
        public static void commands()
        {

            string[] commands = new string[8] { "'help' to show this dialog.", "'changeusername' to change username.", "'version' to show current version.",
                "'quit' to close application.", "'time' to show current time.", "'cal' to open calculator.", "'clear' to reset this window.", "'lan' to change the language for the program.", "'lan' to change the language", "'led' to control the led" };

            foreach (string s in commands)
            {
                Console.WriteLine(s);
                Program.speaker.Speak(s);

            }

        }
    }
}
