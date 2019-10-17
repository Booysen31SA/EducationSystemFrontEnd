using EducationSystemFrontEnd.Requests.Retirement;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EducationSystemFrontEnd.GUI.UserControlWindows
{
    public partial class RetirementUserControl : UserControl
    {
        private static RetirementUserControl _instance;
        private EducationSystem Education = new EducationSystem();
        private RetirementRequest retirementRequest = new RetirementRequest();

        public RetirementUserControl()
        {
            InitializeComponent();
        }

        private void RetirementUserControl_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public static RetirementUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RetirementUserControl();
                }
                return _instance;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            String unae = Education.getUserName();
            if (unae == null)
            {
                Education.CredentialCheck();
                unae = Education.getUserName();
                if (unae != null)
                {
                    String response = retirementRequest.CreateRetirement(persalNumberText.Text, IDText.Text, FirstNameText.Text, SurnameText.Text, Convert.ToDouble(PayOutText.Text), "Pending", Education.getRole());
                    if (response != null)
                    {
                        RootObject retirement = JsonConvert.DeserializeObject<RootObject>(response);
                        persalNumberText.Text = "";
                        IDText.Text = "";
                        FirstNameText.Text = "";
                        SurnameText.Text = "";
                        PayOutText.Text = "";
                        GetAll();
                    }
                }
            }
            else
            {
                String response = retirementRequest.CreateRetirement(persalNumberText.Text, IDText.Text, FirstNameText.Text, SurnameText.Text, Convert.ToDouble(PayOutText.Text), "Pending", Education.getRole());
                if (response != null)
                {
                    RootObject retirement = JsonConvert.DeserializeObject<RootObject>(response);
                    persalNumberText.Text = "";
                    IDText.Text = "";
                    FirstNameText.Text = "";
                    SurnameText.Text = "";
                    PayOutText.Text = "";
                    GetAll();
                }
            }
        }

        public void GetAll()
        {
            listView2.Items.Clear();
            String Appointmentresponse = retirementRequest.GetAllRetirements("retirement");
            String DateAndTimeResponse = retirementRequest.GetAllRetirements("retirementStatus");
            listView2.View = View.Details;

            listView2.GridLines = true;
            if (Appointmentresponse != null)
            {
                List<RetirementObj> RetirementCollection = JsonConvert.DeserializeObject<List<RetirementObj>>(Appointmentresponse);
                List<StatusObj> StatusCollection = JsonConvert.DeserializeObject<List<StatusObj>>(DateAndTimeResponse);

                foreach (RetirementObj pl in RetirementCollection)
                {
                    int indexStatus = StatusCollection.FindIndex(delegate (StatusObj i) { return i.persal_Number.Equals(pl.persal_Num); });
                    listView2.Items.Add(new ListViewItem(new string[] { pl.persal_Num, pl.iD, pl.firstName, pl.lastName, pl.payout.ToString(), StatusCollection.ElementAt(indexStatus).request }));
                };
            }
        }

        private void getReadObject(String response)
        {
            listView2.Items.Clear();
            RootObject Retirement = JsonConvert.DeserializeObject<RootObject>(response);
            String persal_Num = Retirement.retirement.persal_Num;
            String iD = Retirement.retirement.iD;
            String firstName = Retirement.retirement.firstName;
            String lastName = Retirement.retirement.lastName;
            String payout = Convert.ToString(Retirement.retirement.payout);
            String request = Retirement.Status.request;
            listView2.Items.Add(new ListViewItem(new string[] { persal_Num,
                                                                iD,
                                                                firstName,
                                                                lastName,
                                                                payout,
                                                                request
            }));
            persalNumberText.Text = persal_Num;
            IDText.Text = iD;
            FirstNameText.Text = firstName;
            SurnameText.Text = lastName;
            PayOutText.Text = payout;
            DeleteRetirement.Text = persal_Num;
        }

        private void ReadSearch_Click_1(object sender, EventArgs e)
        {
            String unae = Education.getUserName();
            if (unae == null)
            {
                Education.CredentialCheck();
                unae = Education.getUserName();
                if (unae != null)
                {
                    String response = retirementRequest.Read(PersalNumberReadtxt.Text, Education.getRole());

                    if (response != null)
                    {
                        getReadObject(response);
                    }
                }
            }
            else
            {
                String response = retirementRequest.Read(PersalNumberReadtxt.Text, Education.getRole());

                if (response != null)
                {
                    getReadObject(response);
                }
            }
        }

        private void GetAllBtn_Click_1(object sender, EventArgs e)
        {
            GetAll();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            String unae = Education.getUserName();
            if (unae == null)
            {
                Education.CredentialCheck();
                unae = Education.getUserName();
                if (unae != null)
                {
                    if (DeleteRetirement.Text == unae)
                    {
                        String response = retirementRequest.DeleteAppointment(DeleteRetirement.Text, Education.getRole());
                        GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete, can Only delete your own Appointment");
                    }
                }
            }
            else
            {
                String response = retirementRequest.DeleteAppointment(DeleteRetirement.Text, Education.getRole());
                GetAll();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            persalNumberText.Text = "";
            IDText.Text = "";
            FirstNameText.Text = "";
            SurnameText.Text = "";
            PayOutText.Text = "";
        }
    }
}