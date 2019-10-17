using EducationSystemFrontEnd.Requests.Appointment;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            if (AppointmentToSeeText.Text.Length <= 0 || ReasonText.Text.Length <= 0)
            {
                MessageBox.Show(this, "Please Fill in the correct details", "Incorrect details");
            }
            else
            {
                String unae = Education.getUserName();
                if (unae == null)
                {
                    Education.CredentialCheck();
                    unae = Education.getUserName();
                    if (unae != null)
                    {
                        String response = appointmentRequest.CreateAppointment(Education.getUserName(), AppointmentToSeeText.Text, getDate(), getTime(), ReasonText.Text, Education.getRole());

                        if (response != null)
                        {
                            RootObject appointment = JsonConvert.DeserializeObject<RootObject>(response);
                            AppointmentToSeeText.Text = "";
                            ReasonText.Text = "";

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
                        AppointmentToSeeText.Text = "";
                        ReasonText.Text = "";
                        GetAll();
                    }
                }
            }
        }

        public void GetAll()
        {
            listView1.Items.Clear();
            String Appointmentresponse = appointmentRequest.GetAllAppointments("appointment");
            String DateAndTimeResponse = appointmentRequest.GetAllAppointments("dateandtime"); ;
            String ReasonResponse = appointmentRequest.GetAllAppointments("reason");
            listView1.View = View.Details;

            listView1.GridLines = true;
            if (Appointmentresponse != null)
            {
                List<AppointmentObj> AppointmentCollection = JsonConvert.DeserializeObject<List<AppointmentObj>>(Appointmentresponse);
                List<DateAndTimeObj> DateAndTimeCollection = JsonConvert.DeserializeObject<List<DateAndTimeObj>>(DateAndTimeResponse);
                List<ReasonObj> ReasonCollection = JsonConvert.DeserializeObject<List<ReasonObj>>(ReasonResponse);

                foreach (AppointmentObj pl in AppointmentCollection)
                {
                    int indexDateAndTime = DateAndTimeCollection.FindIndex(delegate (DateAndTimeObj i) { return i.persal_Number.Equals(pl.PersalNumber); });
                    int indexReason = ReasonCollection.FindIndex(delegate (ReasonObj i) { return i.persal_Number.Equals(pl.PersalNumber); });
                    String date = DateAndTimeCollection.ElementAt(indexDateAndTime).date;
                    String time = DateAndTimeCollection.ElementAt(indexDateAndTime).time;
                    String reason = ReasonCollection.ElementAt(indexDateAndTime).reason;
                    listView1.Items.Add(new ListViewItem(new string[] { pl.PersalNumber, pl.AppointmentToSee, date, time, reason }));
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

        private void getReadObject(String response)
        {
            listView1.Items.Clear();
            RootObject appointment = JsonConvert.DeserializeObject<RootObject>(response);
            String pNumber = appointment.Appointment.PersalNumber;
            String toSee = appointment.Appointment.AppointmentToSee;
            String date = appointment.DateAndTime.date;
            String time = appointment.DateAndTime.time;
            String reason = appointment.Reason.reason;
            listView1.Items.Add(new ListViewItem(new string[] { pNumber,
                                                                toSee,
                                                                date,
                                                                time,
                                                                reason }));
            AppointmentToSeeText.Text = pNumber;
            ReasonText.Text = reason;
            DeleteAppointment.Text = pNumber;
        }

        private void ReadSearch_Click(object sender, EventArgs e)
        {
            if (PersalNumberReadtxt.Text.Length > 0)
            {
                String unae = Education.getUserName();
                if (unae == null)
                {
                    Education.CredentialCheck();
                    unae = Education.getUserName();
                    if (unae != null)
                    {
                        String response = appointmentRequest.ReadAppointment(PersalNumberReadtxt.Text, Education.getRole());

                        if (response != null)
                        {
                            getReadObject(response);
                        }
                    }
                }
                else
                {
                    String response = appointmentRequest.ReadAppointment(PersalNumberReadtxt.Text, Education.getRole());

                    if (response != null)
                    {
                        getReadObject(response);
                    }
                }
            }
            else { MessageBox.Show(this, "Please Fill in the correct details", "Incorrect details"); }
        }

        private void GetAllBtn_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (DeleteAppointment.Text.Length > 0)
            {
                String unae = Education.getUserName();
                if (unae == null)
                {
                    Education.CredentialCheck();
                    unae = Education.getUserName();
                    if (unae != null)
                    {
                        if (DeleteAppointment.Text == unae)
                        {
                            String response = appointmentRequest.DeleteAppointment(DeleteAppointment.Text, Education.getRole());
                            DeleteAppointment.Text = "";
                            GetAll();
                        }
                        else
                        {
                            MessageBox.Show("Unable to Delete, can Only delete your own Appointment");
                            DeleteAppointment.Text = "";
                        }
                    }
                }
                else
                {
                    if (DeleteAppointment.Text == unae)
                    {
                        String response = appointmentRequest.DeleteAppointment(DeleteAppointment.Text, Education.getRole());
                        DeleteAppointment.Text = "";
                        GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete, can Only delete your own Appointment");
                        DeleteAppointment.Text = "";
                    }
                }
            }
            else { MessageBox.Show(this, "Please Fill in the correct details", "Incorrect details"); }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AppointmentToSeeText.Text = "";
            ReasonText.Text = "";
        }
    }
}