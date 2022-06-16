using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alarm501_Library;
namespace CorrieNaughton.CIS501.AlarmClock
{
    public partial class AlarmForm : Form
    {
        private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        private Alarm501_Library.Controller c;
        private Model m;
        private OpenEdit openEdit;
        private Observe observe;
        private EditAlarms editAlarms;
        private Snooze snooze;
        private Stop stop;
        private Close close;
        private Start start;
        private Activate check;
        /// <summary>
        /// ititialization of alarm
        /// </summary>
        /// <param name="c"></param>
        public AlarmForm(Controller c, Model m)
        {
            InitializeComponent();
            this.c = c;
            this.m = m;
            openEdit = CreateAlarmForm.Open;
            editAlarms = EditAlarm.Edit;
            observe = GetAlarms.update;
            snooze = EditAlarm.Snooze;
            stop = EditAlarm.Stop;
            close = WriteToText.Close;
            start = EditAlarm.StarterAlarms;
            check = EditAlarm.Timer;
            uxEdit_Button.Enabled = uxSnoozeButton.Enabled = uxStop_Button.Enabled = false;
            uxLabel.Visible = false;
            uxAlarmType.Visible = false;

            start(m);

            myTimer.Tick += new EventHandler(TimerEvent);
            myTimer.Interval = 1000;
            myTimer.Start();
        }
        /// <summary>
        /// timmer event occurs every second
        /// </summary>
        /// <param name="myObject"></param>
        /// <param name="myEventArgs"></param>
        private void TimerEvent(Object myObject, EventArgs myEventArgs)
        {
            if (uxListBox.SelectedIndex != -1) uxEdit_Button.Enabled = true;
            else uxEdit_Button.Enabled = false;
            List<string> list = observe(m);
            updateListbox(list);
            Sounds sound = check(m, out bool activate);
            if (activate)
            {
                switch (sound)
                {
                    case Sounds.Beacon:
                        SystemSounds.Asterisk.Play();
                        uxAlarmType.Text = "Beacon";
                        break;
                    case Sounds.Chimes:
                        SystemSounds.Beep.Play();
                        uxAlarmType.Text = "Chimes";
                        break;
                    case Sounds.Circuit:
                        SystemSounds.Exclamation.Play();
                        uxAlarmType.Text = "Circuit";
                        break;
                    case Sounds.Radar:
                        SystemSounds.Hand.Play();
                        uxAlarmType.Text = "Radar";
                        break;
                    default:
                        SystemSounds.Question.Play();
                        uxAlarmType.Text = "Reflection";
                        break;
                }
                uxLabel.Visible = true;
                uxAlarmType.Visible = true;
                uxStop_Button.Enabled = true;
                uxSnoozeButton.Enabled = true;
            }

        }
        /// <summary>
        /// updates listbox
        /// </summary>
        /// <param name="list"></param>
        private void updateListbox(List<string> list)
        {
            int i = 0;
            foreach (var item in list)
            {
                if (i >= uxListBox.Items.Count)
                {
                    uxListBox.Items.Add(item);
                }
                else
                {
                    if (String.Compare(uxListBox.Items[i].ToString(), item) != 0)
                        uxListBox.Items.Insert(i, item);
                }
                i++;
            }

        }
        /// <summary>
        /// edit click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEdit_Button_Click(object sender, EventArgs e)
        {
            int selected = uxListBox.SelectedIndex;
            editAlarms(m, c, selected);
            openEdit(m, c);
            uxListBox.Items.RemoveAt(selected);
        }
        /// <summary>
        /// plus click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void uxPlus_Button_Click(object sender, EventArgs e)
        {
            openEdit(m, c);
        }
        /// <summary>
        /// snooze click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSnoozeButton_Click(object sender, EventArgs e)
        {
            uxSnoozeButton.Enabled = uxStop_Button.Enabled = false;
            uxLabel.Visible = false;
            uxAlarmType.Visible = false;
            uxListBox.Items.RemoveAt(snooze(m));
        }
        /// <summary>
        /// stop click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStop_Button_Click(object sender, EventArgs e)
        {
            uxSnoozeButton.Enabled = uxStop_Button.Enabled = false;
            uxLabel.Visible = false;
            uxAlarmType.Visible = false;
            int i = stop(m);
            uxListBox.Items.RemoveAt(i);
        }
        /// <summary>
        /// application closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Alarm501_FormClosing(object sender, FormClosingEventArgs e)
        {
            close(m);
        }
    }
}
