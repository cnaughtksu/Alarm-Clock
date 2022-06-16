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
namespace Alarm501_GUI
{
    public delegate void OpenEditForm(Model m);
    public delegate void RemoveAlarm(int i, Model m);
    public delegate int Snooze(Model m);
    public delegate int Stop(Model m);
    public delegate List<string> Observe(Model m);
    public delegate void Close(Model m);
    public delegate void Start(Model m);
    public delegate Sounds Activate(Model m, out bool activate);
    /// <summary>
    /// alarm application
    /// </summary>
    public partial class Alarm501 : Form
    {
        private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        private Model m;
        private OpenEditForm open = Alarm501Controller.Open;
        private Observe observe = GetAlarms.update;
        private RemoveAlarm remove = EditAlarms.RemoveAlarm;
        private Snooze snooze = EditAlarms.Snooze;
        private Stop stop = EditAlarms.Stop;
        private Close close = WriteToText.Close;
        private Start start = EditAlarms.StarterAlarms;
        private Activate check = EditAlarms.Check;
        /// <summary>
        /// ititialization of alarm
        /// </summary>
        /// <param name="c"></param>
        public Alarm501(Model m)
        {
            InitializeComponent();
            this.m = m;
            
            
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
                         uxAlarmType.Text = "Beacon";
                        break;
                    case Sounds.Chimes:
                        uxAlarmType.Text = "Chimes";
                        break;
                    case Sounds.Circuit:
                        uxAlarmType.Text = "Circuit";
                        break;
                    case Sounds.Radar:
                        uxAlarmType.Text = "Radar";
                        break;
                    default:
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
            remove(selected, m);
            open(m);
            uxListBox.Items.RemoveAt(selected);
        }
        /// <summary>
        /// plus click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void uxPlus_Button_Click(object sender, EventArgs e)
        {
            open(m);
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
