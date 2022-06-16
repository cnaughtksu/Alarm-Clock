using System;
using System.Collections.Generic;
using System.Text;

namespace Alarm501_Library
{
    /// <summary>
    /// Instance of an Alarm
    /// </summary>
    public class Alarm
    {
        private int h, m, s;
        private string mes;
        private bool on;
        private Sounds sound;
        private int snooze;
        /// <summary>
        /// Initialization of Alarm
        /// </summary>
        /// <param name="h">hour</param>
        /// <param name="m">minute</param>
        /// <param name="s">sec</param>
        /// <param name="mes">am or pm</param>
        /// <param name="on">on or off</param>
        /// <param name="sound">sound</param>
        /// <param name="snooze">time of snooze</param>
        public Alarm(int h, int m, int s, string mes, bool on, Sounds sound, int snooze)
        {
            this.h = h;
            this.m = m;
            this.s = s;
            this.mes = mes;
            this.on = on;
            this.sound = sound;
            this.snooze = snooze;
        }
        /// <summary>
        /// hour of alarm
        /// </summary>
        public int Hour
        {
            get
            {
                return h;
            }
        }
        /// <summary>
        /// minute of alarm
        /// </summary>
        public int Min
        {
            get
            {
                return m;
            }
        }
        /// <summary>
        /// second of alarm
        /// </summary>
        public int Sec
        {
            get
            {
                return s;
            }
        }
        /// <summary>
        /// am or pm
        /// </summary>
        public string AM_PM
        {
            get
            {
                return mes;
            }
        }
        /// <summary>
        /// on or off
        /// </summary>
        public bool On
        {
            get
            {
                return on;
            }
        }

        /// <summary>
        /// alarm sound
        /// </summary>
        public Sounds Sound
        {
            get
            {
                return sound;
            }
        }
        /// <summary>
        /// length of snooze
        /// </summary>
        public int Snooze
        {
            get
            {
                return snooze;
            }
        }

    }
}
