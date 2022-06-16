
namespace Alarm501_GUI
{
    partial class Add_Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxLabel = new System.Windows.Forms.Label();
            this.uxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxComboBox = new System.Windows.Forms.ComboBox();
            this.uxSet_Button = new System.Windows.Forms.Button();
            this.uxCancel_Button = new System.Windows.Forms.Button();
            this.uxCheckBox = new System.Windows.Forms.CheckBox();
            this.uxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Location = new System.Drawing.Point(166, 57);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(56, 17);
            this.uxLabel.TabIndex = 13;
            this.uxLabel.Text = "Snooze";
            // 
            // uxNumericUpDown
            // 
            this.uxNumericUpDown.Location = new System.Drawing.Point(238, 52);
            this.uxNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.uxNumericUpDown.Name = "uxNumericUpDown";
            this.uxNumericUpDown.Size = new System.Drawing.Size(57, 22);
            this.uxNumericUpDown.TabIndex = 12;
            // 
            // uxComboBox
            // 
            this.uxComboBox.FormattingEnabled = true;
            this.uxComboBox.Items.AddRange(new object[] {
            "Beacon",
            "Chimes",
            "Circuit",
            "Reflection"});
            this.uxComboBox.Location = new System.Drawing.Point(12, 50);
            this.uxComboBox.Name = "uxComboBox";
            this.uxComboBox.Size = new System.Drawing.Size(121, 24);
            this.uxComboBox.TabIndex = 11;
            this.uxComboBox.Text = "Radar";
            // 
            // uxSet_Button
            // 
            this.uxSet_Button.Location = new System.Drawing.Point(200, 111);
            this.uxSet_Button.Name = "uxSet_Button";
            this.uxSet_Button.Size = new System.Drawing.Size(87, 27);
            this.uxSet_Button.TabIndex = 10;
            this.uxSet_Button.Text = "Set";
            this.uxSet_Button.UseVisualStyleBackColor = true;
            this.uxSet_Button.Click += new System.EventHandler(this.uxSet_Button_Click);
            // 
            // uxCancel_Button
            // 
            this.uxCancel_Button.Location = new System.Drawing.Point(12, 111);
            this.uxCancel_Button.Name = "uxCancel_Button";
            this.uxCancel_Button.Size = new System.Drawing.Size(84, 27);
            this.uxCancel_Button.TabIndex = 9;
            this.uxCancel_Button.Text = "Cancel";
            this.uxCancel_Button.UseVisualStyleBackColor = true;
            this.uxCancel_Button.Click += new System.EventHandler(this.uxCancel_Button_Click);
            // 
            // uxCheckBox
            // 
            this.uxCheckBox.AutoSize = true;
            this.uxCheckBox.Location = new System.Drawing.Point(238, 12);
            this.uxCheckBox.Name = "uxCheckBox";
            this.uxCheckBox.Size = new System.Drawing.Size(49, 21);
            this.uxCheckBox.TabIndex = 8;
            this.uxCheckBox.Text = "On";
            this.uxCheckBox.UseVisualStyleBackColor = true;
            // 
            // uxDateTimePicker
            // 
            this.uxDateTimePicker.CustomFormat = "hh:mm:ss tt";
            this.uxDateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.uxDateTimePicker.Name = "uxDateTimePicker";
            this.uxDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.uxDateTimePicker.TabIndex = 7;
            // 
            // Add_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 156);
            this.Controls.Add(this.uxLabel);
            this.Controls.Add(this.uxNumericUpDown);
            this.Controls.Add(this.uxComboBox);
            this.Controls.Add(this.uxSet_Button);
            this.Controls.Add(this.uxCancel_Button);
            this.Controls.Add(this.uxCheckBox);
            this.Controls.Add(this.uxDateTimePicker);
            this.Name = "Add_Edit";
            this.Text = "Add_Edit";
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabel;
        private System.Windows.Forms.NumericUpDown uxNumericUpDown;
        private System.Windows.Forms.ComboBox uxComboBox;
        private System.Windows.Forms.Button uxSet_Button;
        private System.Windows.Forms.Button uxCancel_Button;
        private System.Windows.Forms.CheckBox uxCheckBox;
        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
    }
}