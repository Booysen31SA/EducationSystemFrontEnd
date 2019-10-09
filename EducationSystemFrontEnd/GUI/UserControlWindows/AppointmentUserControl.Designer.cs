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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PersalNumberReadtxt = new System.Windows.Forms.TextBox();
            this.ReadSearch = new System.Windows.Forms.Button();
            this.GetAllBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteAppointment = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 88);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(202, 303);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm tt";
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
            this.listView1.Location = new System.Drawing.Point(381, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(722, 526);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Create Appointment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Find a users Appointment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Persal Number";
            // 
            // PersalNumberReadtxt
            // 
            this.PersalNumberReadtxt.Location = new System.Drawing.Point(202, 414);
            this.PersalNumberReadtxt.Name = "PersalNumberReadtxt";
            this.PersalNumberReadtxt.Size = new System.Drawing.Size(159, 20);
            this.PersalNumberReadtxt.TabIndex = 14;
            // 
            // ReadSearch
            // 
            this.ReadSearch.Location = new System.Drawing.Point(202, 456);
            this.ReadSearch.Name = "ReadSearch";
            this.ReadSearch.Size = new System.Drawing.Size(75, 23);
            this.ReadSearch.TabIndex = 15;
            this.ReadSearch.Text = "Search";
            this.ReadSearch.UseVisualStyleBackColor = true;
            this.ReadSearch.Click += new System.EventHandler(this.ReadSearch_Click);
            // 
            // GetAllBtn
            // 
            this.GetAllBtn.Location = new System.Drawing.Point(286, 456);
            this.GetAllBtn.Name = "GetAllBtn";
            this.GetAllBtn.Size = new System.Drawing.Size(75, 23);
            this.GetAllBtn.TabIndex = 16;
            this.GetAllBtn.Text = "Get All";
            this.GetAllBtn.UseVisualStyleBackColor = true;
            this.GetAllBtn.Click += new System.EventHandler(this.GetAllBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Delete Appointment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Persal Number";
            // 
            // DeleteAppointment
            // 
            this.DeleteAppointment.Location = new System.Drawing.Point(202, 547);
            this.DeleteAppointment.Name = "DeleteAppointment";
            this.DeleteAppointment.Size = new System.Drawing.Size(159, 20);
            this.DeleteAppointment.TabIndex = 19;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(202, 588);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.DeleteAppointment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GetAllBtn);
            this.Controls.Add(this.ReadSearch);
            this.Controls.Add(this.PersalNumberReadtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
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
            this.Name = "AppointmentUserControl";
            this.Size = new System.Drawing.Size(1124, 705);
            this.Load += new System.EventHandler(this.AppointmentUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PersalNumberReadtxt;
        private System.Windows.Forms.Button ReadSearch;
        private System.Windows.Forms.Button GetAllBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DeleteAppointment;
        private System.Windows.Forms.Button Delete;
    }
}
