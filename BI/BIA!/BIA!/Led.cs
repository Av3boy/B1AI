using System;
using System.Collections.Generic;

namespace BIA_
{
    class Led
    {

        public static void LedControl()
        {

            bool ledISOn = false;

            if (Program.reconized == "Turn on led")
                ledISOn = true;

            if(Program.reconized == "Change led color")
            Program.speaker.Speak("What color do you want the led to be");

            if(Program.reconized == "")
            {

                Program.speaker.Speak("");
                var pattern = Console.ReadLine(); //vaihda patterni muuttuja esim switch/caseiin että käyttäjä voi vaihtaa ledi patternin esim breathingista paikkallaan pysyvään valoon

                //vaihda ledi patternia
                Program.speaker.Speak("Using: " + pattern);

            }

        }

    }
}
