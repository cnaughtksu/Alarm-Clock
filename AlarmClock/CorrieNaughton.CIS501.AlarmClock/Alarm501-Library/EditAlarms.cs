using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Alarm501_Library
{
    public class EditAlarms
    {
        /// <summary>
        /// retreve alarms from txt file
        /// </summary>
        public static void StarterAlarms(Model m)
        {

            if (File.Exists("Alarm.txt"))
            {
                StreamReader sr = new StreamReader("Alarm.txt");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] alarm = line.Split(',');

                    string s = alarm[5];
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

                    if (string.Compare(alarm[4], " On") == 0)
                        m.alarmList.Add(new Alarm(Convert.ToInt32(alarm[0]), Convert.ToInt32(alarm[1]), Convert.ToInt32(alarm[2]), alarm[3], true, sound, Convert.ToInt32(alarm[6])));
                    else
                        m.alarmList.Add(new Alarm(Convert.ToInt32(alarm[0]), Convert.ToInt32(alarm[1]), Convert.ToInt32(alarm[2]), alarm[3], false, sound, Convert.ToInt32(alarm[6])));
                }
                sr.Close();
            }
        }

        /// <summary>
        /// change time of alarm when snoozed
        /// </summary>
        /// <returns></returns>
        public static int Snooze(Model m)
        {
            int i = 0;
            foreach (Alarm alarm in m.alarmList)
            {
                if (alarm.On)
                {
                    if (m.active.Hour == alarm.Hour && m.active.Min == alarm.Min && m.active.Sec == alarm.Sec && m.active.AM_PM == alarm.AM_PM)
                    {

                        DateTime time;
                        if (alarm.Snooze != 0)
                            time = DateTime.Now.AddMinutes(alarm.Snooze);
                        else
                            time = DateTime.Now.AddSeconds(3);
                        int hour = time.Hour;
                        if (hour > 12) hour -= 12;
                        string am = time.ToShortTimeString();
                        am = am.Substring(am.Length - 2);

                        m.alarmList[i] = new Alarm(hour, time.Minute, time.Second, am, true, alarm.Sound, alarm.Snooze);
                        return i;
                    }

                }
                i++;
            }
            return -1;
        }
        /// <summary>
        /// change alarm to off when stopped
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static int Stop(Model m)
        {
            int i = 0;
            foreach (Alarm alarm in m.alarmList)
            {
                if (alarm.On)
                {
                    if (m.active.Hour == alarm.Hour && m.active.Min == alarm.Min && m.active.Sec == alarm.Sec && m.active.AM_PM == alarm.AM_PM)
                    {

                        m.alarmList[i] = new Alarm(m.active.Hour, m.active.Min, m.active.Sec, m.active.AM_PM, false, alarm.Sound, alarm.Snooze);
                        return i;
                    }  
                }
                i++;
            }
            return -1;
        }
        /// <summary>
        /// check to see of alarm needs to be activated
        /// </summary>
        /// <param name="activate"></param>
        /// <returns></returns>
        public static Sounds Check(Model m, out bool activate)
        {
            activate = false;
            DateTime current = DateTime.Now;
            int hour = current.Hour;
            if (hour > 12) hour -= 12;
            string am = current.ToShortTimeString();
            am = am.Substring(am.Length - 2);

            foreach (Alarm alarm in m.alarmList)
            {
                if (alarm.On == true)
                {
                    if (alarm.Hour == hour && alarm.Min == current.Minute && alarm.Sec == current.Second && string.Compare(alarm.AM_PM, am) == 0)
                    {
                        activate = true;
                        m.active = alarm;
                        m.activeAlarm = current.ToShortTimeString() + " On";
                        return alarm.Sound;
                    }
                    else { activate = false; }
                }
            }
            return Sounds.Beacon;
        }

        /// <summary>
        /// removes edit alarm from list
        /// </summary>
        /// <param name="selected"></param>
        public static void RemoveAlarm(int i, Model m)
        {
            m.alarmList.RemoveAt(i);
        }
        /// <summary>
        /// removes edit alarm from list
        /// </summary>
        /// <param name="selected"></param>
        public static void AddAlarm(Alarm alarm, Model m)
        {
            m.alarmList.Add(alarm);
        }
    }
}
