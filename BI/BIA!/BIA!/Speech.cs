using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Text;

namespace BIA_
{
    class Speech
    {
        public static void speech()
        {
            SpeechRecognitionEngine speech = new SpeechRecognitionEngine();
            speech.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\B1commands.txt")))));
            speech.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(reconized_voice);
            speech.SetInputToDefaultAudioDevice();
            speech.RecognizeAsync(RecognizeMode.Multiple);
        }

        public static void reconized_voice(object sender, SpeechRecognizedEventArgs e)
        {
            Program.reconized = e.Result.Text.ToString();
            Console.WriteLine(Program.reconized);
        }
    }
}
