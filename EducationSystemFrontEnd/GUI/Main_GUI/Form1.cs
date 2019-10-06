using EducationSystemFrontEnd.GUI.LoginForm;
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
        private String persal_Number = null;
        private String User_Role = null;
        private String password = null;
        public EducationSystem()
        {
            InitializeComponent();
            CredentialCheck();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TeacherPanel_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Teacher");

           
        }

        private void Appointment_Panel_Click(object sender, EventArgs e)
        {
            AppointmentRequest appointmentRequest = new AppointmentRequest();
            String response = appointmentRequest.CreateAppointment();

            RootObject appointment = JsonConvert.DeserializeObject<RootObject>(response);
            MessageBox.Show(appointment.Appointment.PersalNumber);
        }

        private void Retirement_Panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Retirement");
        }

        private void Transfer_Panel_Click(object sender, EventArgs e)
        {
          
        }

        private void EducationSystem_Load(object sender, EventArgs e)
        {

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
    }
}
