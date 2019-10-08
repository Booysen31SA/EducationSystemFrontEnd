namespace EducationSystemFrontEnd.GUI.UserControlWindows
{
    partial class AppointmentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AppointmentToSeeText = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Submit = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ReasonText = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Persal_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Appointment_to_See = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReasonCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Appointment To See";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(55, 119);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 2;
            this.Date.Text = "Date";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(55, 149);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(30, 13);
            this.Time.TabIndex = 3;
            this.Time.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reason";
            // 
            // AppointmentToSeeText
            // 
            this.AppointmentToSeeText.Location = new System.Drawing.Point(202, 85);
            this.AppointmentToSeeText.Name = "AppointmentToSeeText";
            this.AppointmentToSeeText.Size = new System.Drawing.Size(159, 20);
            this.AppointmentToSeeText.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " dd/MMMM/yyyy ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(202, 302);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:MM tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(202, 142);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.Value = new System.DateTime(2019, 10, 8, 11, 10, 0, 0);
            // 
            // ReasonText
            // 
            this.ReasonText.Location = new System.Drawing.Point(202, 179);
            this.ReasonText.Name = "ReasonText";
            this.ReasonText.Size = new System.Drawing.Size(159, 96);
            this.ReasonText.TabIndex = 9;
            this.ReasonText.Text = "";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Persal_Number,
            this.Appointment_to_See,
            this.DateCol,
            this.TimeCol,
            this.ReasonCol});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(408, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(695, 567);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Persal_Number
            // 
            this.Persal_Number.Text = "Persal Number";
            this.Persal_Number.Width = 150;
            // 
            // Appointment_to_See
            // 
            this.Appointment_to_See.Text = "Appointment to See";
            this.Appointment_to_See.Width = 150;
            // 
            // DateCol
            // 
            this.DateCol.Text = "Date ";
            this.DateCol.Width = 200;
            // 
            // TimeCol
            // 
            this.TimeCol.Text = "Time";
            this.TimeCol.Width = 100;
            // 
            // ReasonCol
            // 
            this.ReasonCol.Text = "Reason";
            this.ReasonCol.Width = 200;
            // 
            // AppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ReasonText);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AppointmentToSeeText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AppointmentUserControl";
            this.Size = new System.Drawing.Size(1124, 705);
            this.Load += new System.EventHandler(this.AppointmentUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AppointmentToSeeText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RichTextBox ReasonText;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Persal_Number;
        private System.Windows.Forms.ColumnHeader Appointment_to_See;
        private System.Windows.Forms.ColumnHeader DateCol;
        private System.Windows.Forms.ColumnHeader TimeCol;
        private System.Windows.Forms.ColumnHeader ReasonCol;
    }
}
