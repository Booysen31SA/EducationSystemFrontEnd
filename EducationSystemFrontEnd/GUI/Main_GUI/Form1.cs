using EducationSystemFrontEnd.GUI.LoginForm;
using EducationSystemFrontEnd.GUI.UserControlWindows;
using EducationSystemFrontEnd.Requests.Appointment;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace EducationSystemFrontEnd
{
    public partial class EducationSystem : Form
    {
        private static String persal_Number;
        private static String User_Role;
        private static String password;
        private readonly int MAX_HEIGHT;
        public EducationSystem()
        {
            InitializeComponent();
        }


        private void EducationSystem_Load(object sender, EventArgs e)
        {
            CredentialCheck();
            UserDisplay();
            AppointmentDisplay();
            RetirementDisplay();
            TransferDisplay();
            BlankDisplay();
        }
        public String getPassword()
        {
            return password;
        }
        public String getUserName()
        {
            return persal_Number;
        }
        public String getRole()
        {
            return User_Role;
        }

        private void TeacherPanel_Click_1(object sender, EventArgs e)
        {
            UserDisplay();
        }

        private void Appointment_Panel_Click(object sender, EventArgs e)
        {
            AppointmentDisplay();
        }

        private void Retirement_Panel_Click(object sender, EventArgs e)
        {
            RetirementDisplay();
        }

        private void Transfer_Panel_Click(object sender, EventArgs e)
        {
            TransferDisplay();
        }


        public void CredentialCheck()
        {
            if (persal_Number == null || User_Role == null || password == null)
            {
                Login loginForm = new Login();
                loginForm.Show();
            }
        }
        public void updateCred(String num, String role, String pss)
        {
            persal_Number = num;
            User_Role = role;
            password = pss;
        }

        private void UserDisplay()
        {
            if (!ContentPanel.Controls.Contains(UserUserControl.Instance))
            {
                ContentPanel.Controls.Add(UserUserControl.Instance);
                UserUserControl.Instance.Dock = DockStyle.Fill;
                UserUserControl.Instance.BringToFront();
            }
            else
            {

                UserUserControl.Instance.BringToFront();
            }
        }
        private void AppointmentDisplay()
        {
            if (!ContentPanel.Controls.Contains(AppointmentUserControl.Instance))
            {
                ContentPanel.Controls.Add(AppointmentUserControl.Instance);
                AppointmentUserControl.Instance.Dock = DockStyle.Fill;
                AppointmentUserControl.Instance.BringToFront();
            }
            else
            {
                AppointmentUserControl.Instance.BringToFront();
            }

        }
        private void RetirementDisplay()
        {
            if (!ContentPanel.Controls.Contains(RetirementUserControl.Instance))
            {
                ContentPanel.Controls.Add(RetirementUserControl.Instance);
                RetirementUserControl.Instance.Dock = DockStyle.Fill;
                RetirementUserControl.Instance.BringToFront();
            }
            else
            {
                RetirementUserControl.Instance.BringToFront();
            }
        }
        private void TransferDisplay()
        {
            if (!ContentPanel.Controls.Contains(TransferUserControl.Instance))
            {
                ContentPanel.Controls.Add(TransferUserControl.Instance);
                TransferUserControl.Instance.Dock = DockStyle.Fill;
                TransferUserControl.Instance.BringToFront();
            }
            else
            {
                TransferUserControl.Instance.BringToFront();
            }
        }
        private void BlankDisplay()
        {
            if (!ContentPanel.Controls.Contains(BlacnkUserControl.Instance))
            {
                ContentPanel.Controls.Add(BlacnkUserControl.Instance);
                BlacnkUserControl.Instance.Dock = DockStyle.Fill;
                BlacnkUserControl.Instance.BringToFront();
            }
            else
            {
                BlacnkUserControl.Instance.BringToFront();
            }
        }

        private void TeacherPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
