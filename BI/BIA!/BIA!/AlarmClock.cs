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
        }

        public static void SetAlarm()
        {

            Program.speaker.Speak("Set Alarm. First give me an hour.");
            string alarmHour = Program.reconized;
            Program.speaker.Speak("Now give me the minutes");
            string alarmMinute = Program.reconized;
            Program.speaker.Speak("Ok. i'll wake you up at:" + alarmHour + ":" + alarmMinute);
            Program.AlarmTime = (alarmHour + ":" + alarmMinute + ":00");
        }

    }
}
