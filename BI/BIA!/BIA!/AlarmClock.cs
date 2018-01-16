using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BIA_
{

    class AlarmClock
    {
        public static void alarm()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Alert.wav";
            player.Play();
            System.Threading.Thread.Sleep(3000);
            player.Stop();

        }

        public static void SetCustomAlarm()
        {

            Program.speaker.Speak("Set Alarm, First give me an hour.");
            System.Threading.Thread.Sleep(3000);
            int alarmHour = Int32.Parse(Program.reconized);
            Program.speaker.Speak("Now give me the minutes");
            System.Threading.Thread.Sleep(3000);
            int alarmMinute = Int32.Parse(Program.reconized);
            Program.speaker.Speak("Ok. i'll wake you up at:" + alarmHour + ":" + alarmMinute);
            if (alarmMinute < 10)
            {
                Program.AlarmTime = (alarmHour + ":" + "0" + alarmMinute + ":00");
                Console.WriteLine(Program.AlarmTime);
            }

        }

        public static void SetSchoolAlarm()
        {
            Program.speaker.Speak("Do you have an early alarm or not?");

            Boolean SchoolAlarm = false;

            Boolean EarlyAlarm = true;

            while (true)
            {

                while (SchoolAlarm == false)
                {

                    if (Program.Yes.Contains(Program.reconized, StringComparer.OrdinalIgnoreCase))
                    {
                        Program.speaker.Speak("Okay, choose your morning template !");
                        Program.speaker.Speak("First option is that I want to drink coffee and smoke cigarette in the balcony");
                        Program.speaker.Speak("Second option is that I want only drink coffee");
                        Program.speaker.Speak("Third option is that I want only smoke cigarette in the balcony");
                        Program.speaker.Speak("None of these, just fucking wake me up.");
                        SchoolAlarm = true;
                        continue;
                    }

                    else if (Program.Yes.Contains(Program.reconized, StringComparer.OrdinalIgnoreCase))
                    {
                        Program.speaker.Speak("Okay, choose your morning template !");
                        Program.speaker.Speak("First option is that I want to drink coffee and smoke cigarette in the balcony");
                        Program.speaker.Speak("Second option is that I want only drink coffee");
                        Program.speaker.Speak("Third option is that I want only smoke cigarette in the balcony");
                        Program.speaker.Speak("None of these, just fucking wake me up.");
                        SchoolAlarm = true;
                        continue;
                    }
                }

                while (String.IsNullOrEmpty(Program.reconized))
                {
                    if (!String.IsNullOrEmpty(Program.reconized))
                        continue;
                }

                switch (Program.reconized)
                {
                    case "I think its first option":

                        if (EarlyAlarm == true)
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 7:15");
                            Program.AlarmTime = ("7:15:00");
                        }
                        else
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 9:30");
                            Program.AlarmTime = ("9:30:00");
                        }
                            
                        break;

                    case "I think it's second option":
                        if (EarlyAlarm == true)
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 7:30");
                            Program.AlarmTime = ("7:30:00");
                        }
                        else
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 9:45");
                            Program.AlarmTime = ("9:45:00");
                        }

                        break;
                        

                    case "I think it's third option":
                        if (EarlyAlarm == true)
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 7:45");
                            Program.AlarmTime = ("7:45:00");
                        }
                        else
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 9:50");
                            Program.AlarmTime = ("9:50:00");
                        }

                        break;

                    case "I think it's fourth option":
                        if (EarlyAlarm == true)
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 8:00");
                            Program.AlarmTime = ("8:00:00");
                        }
                        else
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 10:00");
                            Program.AlarmTime = ("10:00:00");
                        }

                        break;

                }
                if (!String.IsNullOrEmpty(Program.reconized))
                {
                    Program.reconized = "";
                }
            }
        }
    }
}
