using System;
using System.Collections.Generic;
using System.Text;

namespace Alarm501_Library
{
    /// <summary>
    /// the different sounds
    /// </summary>
    public enum Sounds
    {
        Radar, Beacon, Chimes, Circuit, Reflection
    }
    /// <summary>
    /// library of alarms
    /// </summary>
    public class Model
    {
        public List<Alarm> alarmList = new List<Alarm>();
        public Alarm active = null;
        public string activeAlarm = null;


    }
}
