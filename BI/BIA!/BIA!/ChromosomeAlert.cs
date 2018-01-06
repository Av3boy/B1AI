using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace BIA_
{
    class ChromosomeAlert
    {
        public static void player()
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
        
    }
}
