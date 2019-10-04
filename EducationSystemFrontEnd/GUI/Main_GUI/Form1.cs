using EducationSystemFrontEnd.deserialize.Appointment;
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
using static EducationSystemFrontEnd.deserialize.Appointment.appointment;

namespace EducationSystemFrontEnd
{
    public partial class EducationSystem : Form
    {
        public EducationSystem()
        {
            InitializeComponent();
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
            AppointmentSend app = new AppointmentSend();
            String appointment = "";

            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            String json = app.AppointmentCreate();

            Rootobject objList1 = (Rootobject)serializer.Deserialize(json, typeof(Rootobject));

            MessageBox.Show(objList1.reason.reason);
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
    }
}
