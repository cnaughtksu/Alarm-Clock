using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;
using Alarm501_Library;

namespace Alarm501_Console
{
    public class AlarmController
    {
        private Model m;
        createAlarm create = EditAlarms.AddAlarm;
        removeAlarm remove = EditAlarms.RemoveAlarm;
        checkAlarms check = EditAlarms.Check;
        stopAlarm stop = EditAlarms.Stop;
        getAlarms get = GetAlarms.update;
        snoozeAlarm snooze = EditAlarms.Snooze;
        start start = EditAlarms.StarterAlarms;
        close close = WriteToText.Close;
        private static System.Timers.Timer myTimer;

        public AlarmController(Model m)
        {
            this.m = m;
            myTimer = new System.Timers.Timer();
            myTimer.Elapsed += OnTimedEvent;
            myTimer.Interval = 1000;
            myTimer.Start();
            start(m);
            DisplayAlarms();
        }
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {

            Sounds sound = check(m, out bool activate);
            if (activate)
            {
                switch (sound)
                {
                    case Sounds.Beacon:

                        Console.WriteLine("Beacon");
                        break;
                    case Sounds.Chimes:

                        Console.WriteLine("Chimes");
                        break;
                    case Sounds.Circuit:

                        Console.WriteLine("Circuit");
                        break;
                    case Sounds.Radar:

                        Console.WriteLine("Radar");
                        break;
                    default:
              
                        Console.WriteLine("Reflection");
                        break;
                }
                Console.WriteLine("Please Enter 0");
            }

        }

        void StopAlarm()
        {
            stop(m);
            DisplayAlarms();
        }
        void SnoozeAlarm()
        {
            snooze(m);
            DisplayAlarms();
        }
        void AlarmMenu()
        {
            try
            {
                Console.WriteLine("1) Create Alarm 2) Edit Alarm");
                int input = Convert.ToInt32(Console.ReadLine());
                MenuController(input, false);
            }
            catch
            {
                AlarmMenu();
            }
           
        }
        void MenuController(int input, bool activate)
        {
            if (input == 1)
            {
                if (activate)
                {
                    StopAlarm();
                }
                else
                {
                    CreateAlarm();
                }

            }
            else if (input == 2)
            {
                if (activate)
                {
                    SnoozeAlarm();
                }
                else
                {
                    EditAlarm();
                }
                
            }
            else
            {
                activate = true;
                Console.WriteLine("1) Stop 2) Snooze");
                input = Convert.ToInt32(Console.ReadLine());
                MenuController(input, true);

            }
        }
        void DisplayAlarms()
        {
            int i = 0;
            List<string> alarms = get(m);
            foreach(string alarm in alarms)
            {
                i ++;
                Console.WriteLine(i + ") " + alarm);
            }
            close(m);
            AlarmMenu();
        }

        void CreateAlarm()
        {

            Console.WriteLine("Hour(1-12): ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Min(0-59): ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sec(0-59): ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1) AM 2) PM");
            int AM = Convert.ToInt32(Console.ReadLine());
            string am = "PM";
            if (AM == 1) { am = "AM"; }
            Console.WriteLine("1) Radar 2) Beacon 3) Chimes 4) Circuit 5) Reflection");
            int Sound = Convert.ToInt32(Console.ReadLine());
            Sounds sound;
            switch (Sound)
            {
                case 1:
                    sound = Sounds.Radar;
                    break;
                case 2:
                    sound = Sounds.Beacon;
                    break;
                case 3:
                    sound = Sounds.Chimes;
                    break;
                case 4:
                    sound = Sounds.Circuit;
                    break;
                default:
                    sound = Sounds.Reflection;
                    break;
            }
            Console.WriteLine("1) On 2) Off");
            int On = Convert.ToInt32(Console.ReadLine());
            bool on = false;
            if (On == 1) { on = true; }
            Console.WriteLine("Snooze(0-59): ");
            int snooze = Convert.ToInt32(Console.ReadLine());

            Alarm alarm = new Alarm(hour, min, sec, am, on, sound, snooze);
            
            create(alarm, m);
            DisplayAlarms();
        }
        void EditAlarm()
        {
            try
            {
                Console.Write("Enter Alarm Index: ");
                int input = Convert.ToInt32(Console.ReadLine()) - 1;

                remove(input, m);
                CreateAlarm();
            }
            catch
            {
                AlarmMenu();
            }
            
        }
    }
}
