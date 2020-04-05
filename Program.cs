using System;
using System.Media;
using System.Speech.Synthesis;
using System.Timers;
using System.IO;

namespace B1AI
{
    class Program
    {

        public static SpeechSynthesizer speaker = new SpeechSynthesizer();
        public static SoundPlayer player = new SoundPlayer();

        public static bool admin = false;
        public static bool AdminIdentity = false;
        public static bool WrongPassword = false;

        public static string Username;
        public static string AlarmTime;
        public static string reconized;
        public static int BeforeBusLeaving;

        public static string username = Environment.UserName;
        public static string activeLanguage = "English";
        public static string logpath = username + @"\B1log.txt";
        public static string configpath = username + @"\B1config.txt";

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