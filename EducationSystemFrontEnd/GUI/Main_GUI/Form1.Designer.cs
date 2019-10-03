namespace EducationSystemFrontEnd
{
    partial class EducationSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Transfer_Panel = new System.Windows.Forms.Panel();
            this.Transfer = new System.Windows.Forms.Label();
            this.Retirement_Panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Appointment_Panel = new System.Windows.Forms.Panel();
            this.Appointment = new System.Windows.Forms.Label();
            this.TeacherPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Transfer_Panel.SuspendLayout();
            this.Retirement_Panel.SuspendLayout();
            this.Appointment_Panel.SuspendLayout();
            this.TeacherPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Transfer_Panel);
            this.panel1.Controls.Add(this.Retirement_Panel);
            this.panel1.Controls.Add(this.Appointment_Panel);
            this.panel1.Controls.Add(this.TeacherPanel);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 530);
            this.panel1.TabIndex = 0;
            // 
            // Transfer_Panel
            // 
            this.Transfer_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Transfer_Panel.Controls.Add(this.Transfer);
            this.Transfer_Panel.Location = new System.Drawing.Point(0, 240);
            this.Transfer_Panel.Name = "Transfer_Panel";
            this.Transfer_Panel.Size = new System.Drawing.Size(200, 74);
            this.Transfer_Panel.TabIndex = 2;
            this.Transfer_Panel.Click += new System.EventHandler(this.Transfer_Panel_Click);
            // 
            // Transfer
            // 
            this.Transfer.AutoSize = true;
            this.Transfer.Location = new System.Drawing.Point(71, 31);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(46, 13);
            this.Transfer.TabIndex = 0;
            this.Transfer.Text = "Transfer";
            // 
            // Retirement_Panel
            // 
            this.Retirement_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Retirement_Panel.Controls.Add(this.label4);
            this.Retirement_Panel.Location = new System.Drawing.Point(0, 160);
            this.Retirement_Panel.Name = "Retirement_Panel";
            this.Retirement_Panel.Size = new System.Drawing.Size(200, 74);
            this.Retirement_Panel.TabIndex = 2;
            this.Retirement_Panel.Click += new System.EventHandler(this.Retirement_Panel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Retirement";
            // 
            // Appointment_Panel
            // 
            this.Appointment_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Appointment_Panel.Controls.Add(this.Appointment);
            this.Appointment_Panel.Location = new System.Drawing.Point(0, 80);
            this.Appointment_Panel.Name = "Appointment_Panel";
            this.Appointment_Panel.Size = new System.Drawing.Size(200, 74);
            this.Appointment_Panel.TabIndex = 1;
            this.Appointment_Panel.Click += new System.EventHandler(this.Appointment_Panel_Click);
            // 
            // Appointment
            // 
            this.Appointment.AutoSize = true;
            this.Appointment.Location = new System.Drawing.Point(71, 31);
            this.Appointment.Name = "Appointment";
            this.Appointment.Size = new System.Drawing.Size(66, 13);
            this.Appointment.TabIndex = 0;
            this.Appointment.Text = "Appointment";
            // 
            // TeacherPanel
            // 
            this.TeacherPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeacherPanel.Controls.Add(this.label2);
            this.TeacherPanel.Location = new System.Drawing.Point(0, 0);
            this.TeacherPanel.Name = "TeacherPanel";
            this.TeacherPanel.Size = new System.Drawing.Size(200, 74);
            this.TeacherPanel.TabIndex = 0;
            this.TeacherPanel.Click += new System.EventHandler(this.TeacherPanel_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teacher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Education System";
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContentPanel.Location = new System.Drawing.Point(230, 60);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(919, 530);
            this.ContentPanel.TabIndex = 2;
            // 
            // EducationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 602);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "EducationSystem";
            this.Text = "Education System";
            this.Load += new System.EventHandler(this.EducationSystem_Load);
            this.panel1.ResumeLayout(false);
            this.Transfer_Panel.ResumeLayout(false);
            this.Transfer_Panel.PerformLayout();
            this.Retirement_Panel.ResumeLayout(false);
            this.Retirement_Panel.PerformLayout();
            this.Appointment_Panel.ResumeLayout(false);
            this.Appointment_Panel.PerformLayout();
            this.TeacherPanel.ResumeLayout(false);
            this.TeacherPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel TeacherPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Retirement_Panel;
        private System.Windows.Forms.Panel Transfer_Panel;
        private System.Windows.Forms.Label Transfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Appointment_Panel;
        private System.Windows.Forms.Label Appointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ContentPanel;
    }
}

