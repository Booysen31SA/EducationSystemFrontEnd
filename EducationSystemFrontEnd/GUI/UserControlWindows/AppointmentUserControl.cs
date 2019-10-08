﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationSystemFrontEnd.Requests.Appointment;
using Newtonsoft.Json;

namespace EducationSystemFrontEnd.GUI.UserControlWindows
{
    public partial class AppointmentUserControl : UserControl
    {
        private static AppointmentUserControl _instance;
        private EducationSystem Education = new EducationSystem();
        private AppointmentRequest appointmentRequest = new AppointmentRequest();
        public AppointmentUserControl()
        {
            InitializeComponent();
        }

        private void AppointmentUserControl_Load(object sender, EventArgs e)
        {
            GetAll();
        }
        public static AppointmentUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppointmentUserControl();
                }
                return _instance;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            String unae = Education.getUserName();
            String response = appointmentRequest.CreateAppointment(Education.getUserName(), AppointmentToSeeText.Text, getDate(), getTime(), ReasonText.Text, Education.getRole());

            if(response != null)
            {
                RootObject appointment = JsonConvert.DeserializeObject<RootObject>(response);
                GetAll();
            }
            
        }

        private void GetAll()
        {
            listView1.Items.Clear();
            String response = appointmentRequest.GetAllAppointments();
            listView1.View = View.Details;

           
            listView1.GridLines = true;
            if (response != null)
            {
                List<AppointmentObj> AppointmentCollection = JsonConvert.DeserializeObject<List<AppointmentObj>>(response);

                foreach (AppointmentObj pl in AppointmentCollection)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { pl.PersalNumber, pl.AppointmentToSee}));
                }
            }
        }
        private String getDate()
        {
            string theDate = dateTimePicker1.Value.ToString("dd/MMMM/yyyy");
            return theDate;
        }
        private String getTime()
        {
            string theTimeH = dateTimePicker2.Value.ToString("HH");
            string theTimeM = dateTimePicker2.Value.ToString("MM");
            return theTimeH + "h" + theTimeM;
        }
    }
}