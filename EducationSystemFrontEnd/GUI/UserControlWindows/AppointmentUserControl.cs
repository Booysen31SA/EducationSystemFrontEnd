using System;
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
            if(unae == null)
            {
                Education.CredentialCheck();
                unae = Education.getUserName();
                if(unae != null)
                {
                    String response = appointmentRequest.CreateAppointment(Education.getUserName(), AppointmentToSeeText.Text, getDate(), getTime(), ReasonText.Text, Education.getRole());

                    if (response != null)
                    {
                        RootObject appointment = JsonConvert.DeserializeObject<RootObject>(response);
                        GetAll();
                    }
                }

            }
            else
            {
                String response = appointmentRequest.CreateAppointment(Education.getUserName(), AppointmentToSeeText.Text, getDate(), getTime(), ReasonText.Text, Education.getRole());

                if (response != null)
                {
                    RootObject appointment = JsonConvert.DeserializeObject<RootObject>(response);
                    GetAll();
                }
            }
            
        }

        public void GetAll()
        {
            listView1.Items.Clear();
            String Appointmentresponse = appointmentRequest.GetAllAppointments("appointment", Education.getRole());
            String DateAndTimeResponse = appointmentRequest.GetAllAppointments("dateandtime", Education.getRole()); ;
            String ReasonResponse = appointmentRequest.GetAllAppointments("reason", Education.getRole());
            listView1.View = View.Details;

           
            listView1.GridLines = true;
            if (Appointmentresponse != null)
            {
                List<AppointmentObj> AppointmentCollection = JsonConvert.DeserializeObject<List<AppointmentObj>>(Appointmentresponse);
                List<DateAndTimeObj> DateAndTimeCollection = JsonConvert.DeserializeObject<List<DateAndTimeObj>>(DateAndTimeResponse);
                List<ReasonObj> ReasonCollection = JsonConvert.DeserializeObject<List<ReasonObj>>(ReasonResponse);

                foreach (AppointmentObj pl in AppointmentCollection)
                {
                    int indexDateAndTime = DateAndTimeCollection.FindIndex(delegate(DateAndTimeObj i) { return i.persal_Number == pl.PersalNumber; });
                    int indexReason = ReasonCollection.FindIndex(delegate (ReasonObj i) { return i.persal_Number == pl.PersalNumber; });
                    String date = DateAndTimeCollection.ElementAt(indexDateAndTime).date;
                    String time = DateAndTimeCollection.ElementAt(indexDateAndTime).time;
                    String reason = ReasonCollection.ElementAt(indexDateAndTime).reason;
                    listView1.Items.Add(new ListViewItem(new string[] { pl.PersalNumber, pl.AppointmentToSee, date, time, reason}));

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
