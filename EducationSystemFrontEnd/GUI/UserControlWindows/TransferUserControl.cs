using EducationSystemFrontEnd.Requests.School;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EducationSystemFrontEnd.GUI.UserControlWindows
{
    public partial class TransferUserControl : UserControl
    {
        private static TransferUserControl _instance;
        private TransferRequest transferRequest = new TransferRequest();
        private EducationSystem Education = new EducationSystem();

        public TransferUserControl()
        {
            InitializeComponent();
        }

        private void TransferUserControl_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public static TransferUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TransferUserControl();
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
                    String response = transferRequest.CreateRetirement(persalNumberText.Text, PreviousSchoolText.Text, NewSchoolText.Text, Convert.ToInt32(NewSalaryText.Text), "Pending", Education.getRole());
                    if (response != null)
                    {
                        RootObject retirement = JsonConvert.DeserializeObject<RootObject>(response);
                        persalNumberText.Text = "";
                        PreviousSchoolText.Text = "";
                        NewSchoolText.Text = "";
                        NewSalaryText.Text = "";
                        GetAll();
                    }
                }
            }
            else
            {
                String response = transferRequest.CreateRetirement(persalNumberText.Text, PreviousSchoolText.Text, NewSchoolText.Text, Convert.ToInt32(NewSalaryText.Text), comboBox1.Text, Education.getRole());
                if (response != null)
                {
                    RootObject retirement = JsonConvert.DeserializeObject<RootObject>(response);
                    persalNumberText.Text = "";
                    PreviousSchoolText.Text = "";
                    NewSchoolText.Text = "";
                    NewSalaryText.Text = "";
                    GetAll();
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            persalNumberText.Text = "";
            PreviousSchoolText.Text = "";
            NewSchoolText.Text = "";
            NewSalaryText.Text = "";
        }

        private void ReadSearch_Click(object sender, EventArgs e)
        {
            String unae = Education.getUserName();
            if (unae == null)
            {
                Education.CredentialCheck();
                unae = Education.getUserName();
                if (unae != null)
                {
                    String response = transferRequest.ReadAppointment(PersalNumberReadtxt.Text, Education.getRole());

                    if (response != null)
                    {
                        getReadObject(response);
                    }
                }
            }
            else
            {
                String response = transferRequest.ReadAppointment(PersalNumberReadtxt.Text, Education.getRole());

                if (response != null)
                {
                    getReadObject(response);
                }
            }
        }

        private void GetAllBtn_Click(object sender, EventArgs e)
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
                    if (DeleteTransfer.Text == unae)
                    {
                        String response = transferRequest.DeleteAppointment(DeleteTransfer.Text, Education.getRole());
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
                String response = transferRequest.DeleteAppointment(DeleteTransfer.Text, Education.getRole());
                GetAll();
            }
        }

        public void GetAll()
        {
            listView2.Items.Clear();
            String Appointmentresponse = transferRequest.GetAllAppointments("Transfer");
            String DateAndTimeResponse = transferRequest.GetAllAppointments("Status");
            listView2.View = View.Details;

            listView2.GridLines = true;
            if (Appointmentresponse != null)
            {
                List<TransferObj> RetirementCollection = JsonConvert.DeserializeObject<List<TransferObj>>(Appointmentresponse);
                List<Status> StatusCollection = JsonConvert.DeserializeObject<List<Status>>(DateAndTimeResponse);

                foreach (TransferObj pl in RetirementCollection)
                {
                    int indexStatus = StatusCollection.FindIndex(delegate (Status i) { return i.persal_Number.Equals(pl.persalNumber); });
                    listView2.Items.Add(new ListViewItem(new string[] { pl.persalNumber, pl.previousSchool, pl.schoolName, Convert.ToString(pl.teacherAmount), StatusCollection.ElementAt(indexStatus).statusRequest }));
                };
            }
        }

        private void getReadObject(String response)
        {
            listView2.Items.Clear();
            RootObject Transfer = JsonConvert.DeserializeObject<RootObject>(response);
            String persal_Num = Transfer.Transfer.persalNumber;
            String previousSchool = Transfer.Transfer.previousSchool;
            String NewSchool = Transfer.Transfer.schoolName;
            String payout = Convert.ToString(Transfer.Transfer.teacherAmount);
            String request = Transfer.status.statusRequest;
            listView2.Items.Add(new ListViewItem(new string[] { persal_Num,
                                                                previousSchool,
                                                                NewSchool,
                                                                payout,
                                                                request
            }));
            persalNumberText.Text = persal_Num;
            PreviousSchoolText.Text = previousSchool;
            NewSchoolText.Text = NewSchool;
            NewSalaryText.Text = payout;
            DeleteTransfer.Text = persal_Num;
        }
    }
}