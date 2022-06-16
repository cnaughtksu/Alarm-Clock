using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Alarm501_Library
{
    public class WriteToText
    {

        /// <summary>
        /// write to txt file when closing application
        /// </summary>
        public static void Close(Model m)
        {
            File.WriteAllText("Alarm.txt", String.Empty);
            StreamWriter sw = new StreamWriter("Alarm.txt");
            foreach (Alarm alarm in m.alarmList)
            {
                if (alarm.On)
                    sw.WriteLine(alarm.Hour + "," + alarm.Min + "," + alarm.Sec + "," + alarm.AM_PM + ", On," + alarm.Sound + "," + alarm.Snooze);
                else
                {
                    sw.WriteLine(alarm.Hour + "," + alarm.Min + "," + alarm.Sec + "," + alarm.AM_PM + ", Off," + alarm.Sound + "," + alarm.Snooze);
                }
            }
            sw.Close();
        }
    }
}
