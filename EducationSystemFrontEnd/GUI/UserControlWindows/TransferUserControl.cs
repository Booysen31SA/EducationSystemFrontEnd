using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationSystemFrontEnd.Requests.School;
using Newtonsoft.Json;

namespace EducationSystemFrontEnd.GUI.UserControlWindows
{
    public partial class TransferUserControl : UserControl
    {
        private static TransferUserControl _instance;
        private TransferRequest transferRequest = new TransferRequest();
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

        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }

        private void ReadSearch_Click(object sender, EventArgs e)
        {

        }

        private void GetAllBtn_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

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
    }
}
