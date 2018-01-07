using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.Media;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Timers;

namespace BIA_
{
    class Program

    {

        public static Boolean admin = false;

        public static SpeechSynthesizer speaker = new SpeechSynthesizer();

        public static string reconized = string.Empty;
        public static string GetUsername = Environment.UserName;
        public static string logpath = @"C:\Users\" + GetUsername + @"\B1log.txt";
        public static string configpath = @"C:\Users\" + GetUsername + @"\B1config.txt";
        public static string Username;
        public static string[] helloB1 = { "HI B1", "HELLO B1", "HEY B1" };
        public static string AlarmTime = "";
        public static string B1commands = AppDomain.CurrentDomain.BaseDirectory + "\\B1commands.xml";
        public static void Main()
        {
            
            
            speaker.Rate = 1;
            speaker.Volume = 100;

            Speech.speech();
            Log.log();

        }

        private static void TimerCallback(Object o)
        {

            Console.WriteLine("pillu");
            // Force a garbage collection to occur for this demo.
            GC.Collect();
        }
    }
}