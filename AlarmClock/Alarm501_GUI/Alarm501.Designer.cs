
namespace Alarm501_GUI
{
    partial class Alarm501
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
            this.uxAlarmType = new System.Windows.Forms.Label();
            this.uxLabel = new System.Windows.Forms.Label();
            this.uxStop_Button = new System.Windows.Forms.Button();
            this.uxSnoozeButton = new System.Windows.Forms.Button();
            this.uxListBox = new System.Windows.Forms.ListBox();
            this.uxPlus_Button = new System.Windows.Forms.Button();
            this.uxEdit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxAlarmType
            // 
            this.uxAlarmType.AutoSize = true;
            this.uxAlarmType.Location = new System.Drawing.Point(84, 270);
            this.uxAlarmType.Name = "uxAlarmType";
            this.uxAlarmType.Size = new System.Drawing.Size(0, 17);
            this.uxAlarmType.TabIndex = 14;
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Location = new System.Drawing.Point(57, 190);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(108, 17);
            this.uxLabel.TabIndex = 13;
            this.uxLabel.Text = "Alarm went OFF";
            // 
            // uxStop_Button
            // 
            this.uxStop_Button.Location = new System.Drawing.Point(121, 222);
            this.uxStop_Button.Name = "uxStop_Button";
            this.uxStop_Button.Size = new System.Drawing.Size(85, 39);
            this.uxStop_Button.TabIndex = 12;
            this.uxStop_Button.Text = "Stop";
            this.uxStop_Button.UseVisualStyleBackColor = true;
            this.uxStop_Button.Click += new System.EventHandler(this.uxStop_Button_Click);
            // 
            // uxSnoozeButton
            // 
            this.uxSnoozeButton.Location = new System.Drawing.Point(12, 222);
            this.uxSnoozeButton.Name = "uxSnoozeButton";
            this.uxSnoozeButton.Size = new System.Drawing.Size(85, 39);
            this.uxSnoozeButton.TabIndex = 11;
            this.uxSnoozeButton.Text = "Snooze";
            this.uxSnoozeButton.UseVisualStyleBackColor = true;
            this.uxSnoozeButton.Click += new System.EventHandler(this.uxSnoozeButton_Click);
            // 
            // uxListBox
            // 
            this.uxListBox.FormattingEnabled = true;
            this.uxListBox.ItemHeight = 16;
            this.uxListBox.Location = new System.Drawing.Point(12, 57);
            this.uxListBox.Name = "uxListBox";
            this.uxListBox.Size = new System.Drawing.Size(194, 116);
            this.uxListBox.TabIndex = 10;
            // 
            // uxPlus_Button
            // 
            this.uxPlus_Button.Location = new System.Drawing.Point(121, 12);
            this.uxPlus_Button.Name = "uxPlus_Button";
            this.uxPlus_Button.Size = new System.Drawing.Size(85, 39);
            this.uxPlus_Button.TabIndex = 9;
            this.uxPlus_Button.Text = "+";
            this.uxPlus_Button.UseVisualStyleBackColor = true;
            this.uxPlus_Button.Click += new System.EventHandler(this.uxPlus_Button_Click);
            // 
            // uxEdit_Button
            // 
            this.uxEdit_Button.Location = new System.Drawing.Point(12, 12);
            this.uxEdit_Button.Name = "uxEdit_Button";
            this.uxEdit_Button.Size = new System.Drawing.Size(85, 39);
            this.uxEdit_Button.TabIndex = 8;
            this.uxEdit_Button.Text = "Edit";
            this.uxEdit_Button.UseVisualStyleBackColor = true;
            this.uxEdit_Button.Click += new System.EventHandler(this.uxEdit_Button_Click);
            // 
            // Alarm501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 281);
            this.Controls.Add(this.uxAlarmType);
            this.Controls.Add(this.uxLabel);
            this.Controls.Add(this.uxStop_Button);
            this.Controls.Add(this.uxSnoozeButton);
            this.Controls.Add(this.uxListBox);
            this.Controls.Add(this.uxPlus_Button);
            this.Controls.Add(this.uxEdit_Button);
            this.Name = "Alarm501";
            this.Text = "Alarm501";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Alarm501_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxAlarmType;
        private System.Windows.Forms.Label uxLabel;
        private System.Windows.Forms.Button uxStop_Button;
        private System.Windows.Forms.Button uxSnoozeButton;
        private System.Windows.Forms.ListBox uxListBox;
        private System.Windows.Forms.Button uxPlus_Button;
        private System.Windows.Forms.Button uxEdit_Button;
    }
}