using System;
using System.Media;
using System.Speech.Synthesis;
using System.Timers;

namespace BIA_
{
    class Program
    {

        public static SpeechSynthesizer speaker = new SpeechSynthesizer();
        public static SoundPlayer player = new SoundPlayer();

        public static Boolean admin = false;
        public static Boolean AdminIdentity = false;
        public static Boolean WrongPassword = false;

        public static string CurrentTime;
        public static string Username;
        public static string AlarmTime;
        public static string reconized;
        public static int BeforeBusLeaving;

        public static string GetUsername = Environment.UserName;
        public static string activeLanguage = "English";
        public static string logpath = @"C:\Users\" + GetUsername + @"\B1log.txt";
        public static string configpath = @"C:\Users\" + GetUsername + @"\B1config.txt";

        public static string[] Yes = { "Yeah", "Yes i want", "Yes i have", "Yes", "Sure", "Yes i can", "Yea", "Okay", "Ok", "Okey-dokey", "Roger", "Righto", "Yup", "Right on", "Surely", "Amen", "Totally", "Yessir" };
        public static string[] No = { "Not this time.", "Not now.", "Nope", "Hell no", "Maybe another time.", "I wish I were able to." };
        public static string[] Hey = { "Hey B1", "Hello B1", "Hi B1", "B1 are you there", "Hey B1, are you awake ?" };
        public static void Main()
        {
            speaker.Rate = 1;
            speaker.Volume = 100;
            SpeechRecognition.speech();
            Timers.AtStartup();
            Welcome.welcome();
        }
    }
}