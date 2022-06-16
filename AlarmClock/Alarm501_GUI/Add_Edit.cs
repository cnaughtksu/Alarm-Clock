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
    public delegate void Set(Model m, DateTime time, string s, int i, bool b);
    /// <summary>
    /// add/edit applicaiton
    /// </summary>
    public partial class Add_Edit : Form
    {
        private Model m;
        private Set set;
        /// <summary>
        /// intitialization of application
        /// </summary>
        /// <param name="c"></param>

        public Add_Edit(Model m)
        {
            InitializeComponent();

            uxDateTimePicker.Format = DateTimePickerFormat.Custom;
            uxDateTimePicker.CustomFormat = "hh:mm:ss tt";
            uxDateTimePicker.ShowUpDown = true;

            this.m = m;
            set = Add_EditController.Set;
        }
        /// <summary>
        /// cancel click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCancel_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        /// <summary>
        /// set click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSet_Button_Click(object sender, EventArgs e)
        {
            DateTime time = uxDateTimePicker.Value;
            string sound = uxComboBox.Text;
            int snooze = (int)uxNumericUpDown.Value;
            bool check = uxCheckBox.Checked;
            set(m, time, sound, snooze, check);
            this.Visible = false;
        }
    }
}
