using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrieNaughton.CIS501.AlarmClock
{
    public partial class EditForm : Form
    {
        private Controller cont;
        private Model m;
        private Set set;
        /// <summary> 
        /// </summary>
        /// <param name="c"></param>

        public EditForm(Controller c, Model m)
        {
            InitializeComponent();

            uxDateTimePicker.Format = DateTimePickerFormat.Custom;
            uxDateTimePicker.CustomFormat = "hh:mm:ss tt";
            uxDateTimePicker.ShowUpDown = true;
            cont = c;
            this.m = m;
            set = Add_Edit_Controller.Set;
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
