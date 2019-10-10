namespace EducationSystemFrontEnd.GUI.UserControlWindows
{
    partial class RetirementUserControl
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
            this.Delete = new System.Windows.Forms.Button();
            this.DeleteRetirement = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GetAllBtn = new System.Windows.Forms.Button();
            this.ReadSearch = new System.Windows.Forms.Button();
            this.PersalNumberReadtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Persal_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.First_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Payout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Submit = new System.Windows.Forms.Button();
            this.persalNumberText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.PayOutText = new System.Windows.Forms.TextBox();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(185, 473);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 40;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteRetirement
            // 
            this.DeleteRetirement.Location = new System.Drawing.Point(185, 447);
            this.DeleteRetirement.Name = "DeleteRetirement";
            this.DeleteRetirement.Size = new System.Drawing.Size(159, 20);
            this.DeleteRetirement.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Persal Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Delete Appointment";
            // 
            // GetAllBtn
            // 
            this.GetAllBtn.Location = new System.Drawing.Point(269, 370);
            this.GetAllBtn.Name = "GetAllBtn";
            this.GetAllBtn.Size = new System.Drawing.Size(75, 23);
            this.GetAllBtn.TabIndex = 36;
            this.GetAllBtn.Text = "Get All";
            this.GetAllBtn.UseVisualStyleBackColor = true;
            this.GetAllBtn.Click += new System.EventHandler(this.GetAllBtn_Click_1);
            // 
            // ReadSearch
            // 
            this.ReadSearch.Location = new System.Drawing.Point(185, 370);
            this.ReadSearch.Name = "ReadSearch";
            this.ReadSearch.Size = new System.Drawing.Size(75, 23);
            this.ReadSearch.TabIndex = 35;
            this.ReadSearch.Text = "Search";
            this.ReadSearch.UseVisualStyleBackColor = true;
            this.ReadSearch.Click += new System.EventHandler(this.ReadSearch_Click_1);
            // 
            // PersalNumberReadtxt
            // 
            this.PersalNumberReadtxt.Location = new System.Drawing.Point(185, 344);
            this.PersalNumberReadtxt.Name = "PersalNumberReadtxt";
            this.PersalNumberReadtxt.Size = new System.Drawing.Size(159, 20);
            this.PersalNumberReadtxt.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Persal Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Find a Retirement Request";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Create Retirement Request";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Persal_Number,
            this.ID,
            this.First_Name,
            this.Surname,
            this.Payout,
            this.Status});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(364, 109);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(722, 526);
            this.listView2.TabIndex = 30;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Persal_Number
            // 
            this.Persal_Number.Text = "Persal Number";
            this.Persal_Number.Width = 150;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 150;
            // 
            // First_Name
            // 
            this.First_Name.Text = "First Name";
            this.First_Name.Width = 200;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 100;
            // 
            // Payout
            // 
            this.Payout.Text = "Payout";
            this.Payout.Width = 200;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(185, 253);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 27;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // persalNumberText
            // 
            this.persalNumberText.Location = new System.Drawing.Point(185, 109);
            this.persalNumberText.Name = "persalNumberText";
            this.persalNumberText.Size = new System.Drawing.Size(159, 20);
            this.persalNumberText.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Payout";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(38, 207);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(49, 13);
            this.Time.TabIndex = 23;
            this.Time.Text = "Surname";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(38, 176);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(57, 13);
            this.Date.TabIndex = 22;
            this.Date.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Persal Number";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(185, 140);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(159, 20);
            this.IDText.TabIndex = 42;
            // 
            // PayOutText
            // 
            this.PayOutText.Location = new System.Drawing.Point(185, 227);
            this.PayOutText.Name = "PayOutText";
            this.PayOutText.Size = new System.Drawing.Size(159, 20);
            this.PayOutText.TabIndex = 43;
            // 
            // SurnameText
            // 
            this.SurnameText.Location = new System.Drawing.Point(185, 200);
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(159, 20);
            this.SurnameText.TabIndex = 44;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(185, 169);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(159, 20);
            this.FirstNameText.TabIndex = 45;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(269, 253);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 46;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // RetirementUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.SurnameText);
            this.Controls.Add(this.PayOutText);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.DeleteRetirement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GetAllBtn);
            this.Controls.Add(this.ReadSearch);
            this.Controls.Add(this.PersalNumberReadtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.persalNumberText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label8);
            this.Name = "RetirementUserControl";
            this.Size = new System.Drawing.Size(1124, 705);
            this.Load += new System.EventHandler(this.RetirementUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox DeleteRetirement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GetAllBtn;
        private System.Windows.Forms.Button ReadSearch;
        private System.Windows.Forms.TextBox PersalNumberReadtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Persal_Number;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader First_Name;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Payout;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox persalNumberText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.TextBox PayOutText;
        private System.Windows.Forms.TextBox SurnameText;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button Clear;
    }
}
