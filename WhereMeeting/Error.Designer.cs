using System;
using System.Windows.Forms;

namespace WhereMeeting
{
    partial class Error
    {
        //private Label label1;

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

            Label label1 = new Label();
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            label1.Location = new System.Drawing.Point(69, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(327, 63);
            label1.TabIndex = 0;
            label1.Text = "You are not authenticated!";

            this.SuspendLayout();
            
            // Error
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 143);
            this.Controls.Add(label1);
            this.Name = "Error";
            this.Text = "WhereMeeting - Error";
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
    }
}

