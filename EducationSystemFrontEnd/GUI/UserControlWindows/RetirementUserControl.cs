using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationSystemFrontEnd.Requests.Retirement;
using Newtonsoft.Json;

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

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void GetAllBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReadSearch_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            String unae = Education.getUserName();
            if (unae == null)
            {
                Education.CredentialCheck();
                unae = Education.getUserName();
                if(unae != null)
                {
                    String response = retirementRequest.CreateRetirement(persalNumberText.Text, persalNumberText.Text, FirstNameText.Text, SurnameText.Text, Convert.ToDouble(PayOutText.Text), "Pending", Education.getRole());
                    if (response != null)
                    {
                        RootObject retirement = JsonConvert.DeserializeObject<RootObject>(response);
                    }
                }
            }
            else
            {
                String response = retirementRequest.CreateRetirement(persalNumberText.Text, persalNumberText.Text, FirstNameText.Text, SurnameText.Text, Convert.ToDouble(PayOutText.Text), "Pending", Education.getRole());
                if (response != null)
                {
                    RootObject retirement = JsonConvert.DeserializeObject<RootObject>(response);
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
        }
    }
