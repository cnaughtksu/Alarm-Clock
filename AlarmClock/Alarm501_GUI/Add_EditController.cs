using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alarm501_Library;
namespace Alarm501_GUI
{
    public class Add_EditController
    {
        /// <summary>
        /// set new alarm to list
        /// <param name="s"></param>
        /// <param name="snooze"></param>
        /// <param name="b"></param>
        public static void Set(Model m, DateTime time, string s, int snooze, bool b)
        {
            int hour = time.Hour;
            if (hour > 12) hour -= 12;
            string am = time.ToShortTimeString();
            am = am.Substring(am.Length - 2);

            Sounds sound;
            switch (s)
            {
                case "Radar":
                    sound = Sounds.Radar;
                    break;
                case "Beacon":
                    sound = Sounds.Beacon;
                    break;
                case "Chimes":
                    sound = Sounds.Chimes;
                    break;
                case "Circuit":
                    sound = Sounds.Circuit;
                    break;
                default:
                    sound = Sounds.Reflection;
                    break;
            }
            m.alarmList.Add(new Alarm(hour, time.Minute, time.Second, am, b, sound, snooze));
        }
    }
}
