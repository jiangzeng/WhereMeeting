using System;
using System.Windows.Forms;

namespace WhereMeeting
{
    partial class Home
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
            
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStartLabel = new System.Windows.Forms.Label();
            this.dateEndLabel = new System.Windows.Forms.Label();
            this.timeStartLabel = new System.Windows.Forms.Label();
            this.timeEndLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(802, 566);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(794, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Find A Room";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(14, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 319);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimeStart);
            this.panel1.Controls.Add(this.dateTimeEnd);
            this.panel1.Controls.Add(this.timeStart);
            this.panel1.Controls.Add(this.timeEnd);
            this.panel1.Controls.Add(this.dateStartLabel);
            this.panel1.Controls.Add(this.dateEndLabel);
            this.panel1.Controls.Add(this.timeStartLabel);
            this.panel1.Controls.Add(this.timeEndLabel);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 185);
            this.panel1.TabIndex = 0;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(208, 20);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(109, 23);
            this.dateTimeStart.TabIndex = 0;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(208, 61);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(109, 23);
            this.dateTimeEnd.TabIndex = 1;
            // 
            // timeStart
            // 
            this.timeStart.CustomFormat = "HH:mm";
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeStart.Location = new System.Drawing.Point(533, 20);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(109, 23);
            this.timeStart.TabIndex = 2;
            // 
            // timeEnd
            // 
            this.timeEnd.CustomFormat = "HH:mm";
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeEnd.Location = new System.Drawing.Point(533, 61);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(109, 23);
            this.timeEnd.TabIndex = 3;
            // 
            // dateStartLabel
            // 
            this.dateStartLabel.Location = new System.Drawing.Point(93, 20);
            this.dateStartLabel.Name = "dateStartLabel";
            this.dateStartLabel.Size = new System.Drawing.Size(100, 23);
            this.dateStartLabel.TabIndex = 4;
            this.dateStartLabel.Text = "Start Date:";
            this.dateStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateEndLabel
            // 
            this.dateEndLabel.Location = new System.Drawing.Point(93, 61);
            this.dateEndLabel.Name = "dateEndLabel";
            this.dateEndLabel.Size = new System.Drawing.Size(100, 23);
            this.dateEndLabel.TabIndex = 0;
            this.dateEndLabel.Text = "End Date:";
            this.dateEndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeStartLabel
            // 
            this.timeStartLabel.Location = new System.Drawing.Point(415, 20);
            this.timeStartLabel.Name = "timeStartLabel";
            this.timeStartLabel.Size = new System.Drawing.Size(100, 23);
            this.timeStartLabel.TabIndex = 0;
            this.timeStartLabel.Text = "Start Time:";
            this.timeStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeEndLabel
            // 
            this.timeEndLabel.Location = new System.Drawing.Point(415, 61);
            this.timeEndLabel.Name = "timeEndLabel";
            this.timeEndLabel.Size = new System.Drawing.Size(100, 23);
            this.timeEndLabel.TabIndex = 0;
            this.timeEndLabel.Text = "End Time:";
            this.timeEndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(794, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recent History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 125);
            this.button1.Name = "SearchButton";
            this.button1.Size = new System.Drawing.Size(132, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search a room";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 566);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhereMeeting - Find the right room";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private Panel panel2;
        private Panel panel1;
        private TabPage tabPage2;
        private DateTimePicker dateTimeStart;
        private DateTimePicker dateTimeEnd;
        private DateTimePicker timeStart;
        private DateTimePicker timeEnd;
        private Label dateStartLabel;
        private Label dateEndLabel;
        private Label timeStartLabel;
        private Label timeEndLabel;
        private Button button1;
    }
}