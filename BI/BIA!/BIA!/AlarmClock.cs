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
    }
}
