using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace B1AI
{

    class AlarmClock
    {
        public static void alarm()
        {
            //Program.player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Alert.wav";
            //Program.player.Play();
            //System.Threading.Thread.Sleep(10000);
            //Program.player.Stop();
            Program.speaker.Speak("Good morning" + Program.Username);
            Program.speaker.Speak("Today is" + DateTime.Now.DayOfWeek.ToString());
            Program.speaker.Speak("Current time is" + DateTime.Now.ToString("h.") + DateTime.Now.ToString("mm"));
            Program.speaker.Speak("So you have about" + Program.BeforeBusLeaving + "Minutes before your bus leaves.");
            Program.speaker.Speak("");
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

                    if (Program.Yes.Contains(Program.reconized))
                    {
                        Program.speaker.Speak("Okay, Do you want take your morning with or without coffee ? What about cigarette ?");
                        SchoolAlarm = true;
                        continue;
                    }

                    else if (Program.No.Contains(Program.reconized))
                    {
                        Program.speaker.Speak("Okay, Do you want take your morning with or without coffee ? What about cigarette ?");
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
                    case "Both would be very nice":

                        if (EarlyAlarm == true)
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 7:15");
                            Program.AlarmTime = ("7:15:00");

                            Program.BeforeBusLeaving = 30;
                        }
                        else
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 9:30");
                            Program.AlarmTime = ("9:30:00");

                            Program.BeforeBusLeaving = 30;
                        }
                            
                        break;

                    case "Only coffee, not cigarette this time":
                        if (EarlyAlarm == true)
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 7:30");
                            Program.AlarmTime = ("7:30:00");

                            Program.BeforeBusLeaving = 15;
                        }
                        else
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 9:45");
                            Program.AlarmTime = ("9:45:00");

                            Program.BeforeBusLeaving = 15;
                        }

                        break;
                        

                    case "Only cigarette, not coffee at this time":
                        if (EarlyAlarm == true)
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 7:45");
                            Program.AlarmTime = ("7:45:00");

                            Program.BeforeBusLeaving = 15;
                        }
                        else
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 9:50");
                            Program.AlarmTime = ("9:50:00");

                            Program.BeforeBusLeaving = 15;
                        }

                        break;

                    case "Just wake me up":
                        if (EarlyAlarm == true)
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 8:00");
                            Program.AlarmTime = ("8:00:00");

                            Program.BeforeBusLeaving = 15;
                        }
                        else
                        {
                            Program.speaker.Speak("Okay, I'll wake you up at 10:00");
                            Program.AlarmTime = ("10:00:00");

                            Program.BeforeBusLeaving = 15;
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
