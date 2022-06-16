using System;
using System.Collections.Generic;
using System.Text;

namespace Alarm501_Library
{
    public class GetAlarms 
    {
        /// <summary>
        /// create list of alarms
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static List<string> update(Model m)
        {
            List<string> listBox = new List<string>();

            foreach (var alarm in m.alarmList)
            {
                if (alarm.On)
                {
                    if (alarm.Min < 10)
                    {
                        listBox.Add(alarm.Hour + ":0" + alarm.Min + " " + alarm.AM_PM + " On");
                    }
                    else
                    {
                        listBox.Add(alarm.Hour + ":" + alarm.Min + " " + alarm.AM_PM + " On");
                    }

                }
                else
                {
                    if (alarm.Min < 10)
                    {
                        listBox.Add(alarm.Hour + ":0" + alarm.Min + " " + alarm.AM_PM + " Off");
                    }
                    else
                    {
                        listBox.Add(alarm.Hour + ":" + alarm.Min + " " + alarm.AM_PM + " Off");
                    }

                }
            }
            return listBox;
        }
    }
}
