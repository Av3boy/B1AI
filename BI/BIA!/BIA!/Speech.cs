﻿using System;
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
<<<<<<< HEAD
            Grammar gr = new Grammar(new GrammarBuilder(new Choices("hey mate", "hello", "google", "What can you do", "i am the admin", "27255374", "no", "yes", "mayday mayday", "clear", "chromosome alert", "Shutdown my workstation", "lan", "led")));
            //Grammar SpecifyUsername = new Grammar(new GrammarBuilder(new Choices("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "å", "ä", "ö")));

=======
            Grammar gr = new Grammar(Program.B1commands);
            gr.Name = "B1commands";
            
            //Grammar gr = new Grammar(new GrammarBuilder(new Choices("wake me up at morning","hey mate", "hello", "google", "What can you do", "i am the admin", "27255374", "no", "yes", "mayday mayday", "clear", "chromosome alert", "Shutdown my workstation")));
>>>>>>> 657e56cf370b134da888bd309d0b4534dd37a9eb
            speech.RequestRecognizerUpdate();
            speech.LoadGrammar(gr);
            speech.SpeechRecognized += reconized_voice;
            speech.SetInputToDefaultAudioDevice();
            speech.RecognizeAsync(RecognizeMode.Multiple);
        }

        public static void reconized_voice(object sender, SpeechRecognizedEventArgs e)
        {

            Program.reconized = e.Result.Text.ToString();
            
        }
    }
}
