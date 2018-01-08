using System;
using System.Collections.Generic;
using System.Text;

namespace BIA_
{
    class Language
    {

        public static void LanguageSelector()
        {

            string[] lan = new string[2] { "English", "Finland" };

            foreach (string language in lan)
            {
                Console.WriteLine(language);
                Program.speaker.Speak(language);

            }

            if(Program.reconized == "change the language")
            {

                string input = Program.reconized = "";

                switch(input)
                {

                    case "English":
                        break;

                    case "Finnish":
                        break;

                    default:
                        Program.speaker.Speak("Invalid language: " + input);
                        Console.WriteLine("Invalid language: " + input);
                        break;

                }

            }

        }
    }
}
