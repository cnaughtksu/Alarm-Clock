using System;
using Alarm501_Library;
using System.Collections.Generic;
namespace Alarm501_Console
{
    public delegate void createAlarm(Alarm alarm, Model m);
    public delegate void removeAlarm(int i, Model m);
    public delegate Sounds checkAlarms(Model m, out bool activate);
    public delegate int stopAlarm(Model m);
    public delegate List<string> getAlarms(Model m);
    public delegate int snoozeAlarm(Model m);
    public delegate void start(Model m);
    public delegate void close(Model m);
    class Program
    {
      
        static void Main(string[] args)
        {
            Model m = new Model();
            AlarmController a = new AlarmController(m);

        }

    }
}
