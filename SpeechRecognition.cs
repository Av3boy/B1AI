using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Globalization;

namespace B1AI
{
    class SpeechRecognition
    {
        public static void speech()
        {
            CultureInfo info = new CultureInfo("en-US");
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(info);
            string path = AppDomain.CurrentDomain.BaseDirectory + "B1commands.txt";
            Console.WriteLine(path);
            sre.LoadGrammar(new DictationGrammar());
            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(reconized_voice);
            sre.SetInputToDefaultAudioDevice();
            sre.RecognizeAsync(RecognizeMode.Multiple);
        }

        public static void reconized_voice(object sender, SpeechRecognizedEventArgs e)
        {
            Program.reconized = e.Result.Text.ToString();
            Console.WriteLine(Program.reconized);
        }
    }
}
