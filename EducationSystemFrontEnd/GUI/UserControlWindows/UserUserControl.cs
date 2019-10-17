using EducationSystemFrontEnd.Requests.User;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EducationSystemFrontEnd.GUI.UserControlWindows
{
    public partial class UserUserControl : UserControl
    {
        private static UserUserControl _instance;
        private EducationSystem Education = new EducationSystem();
        private UserRequest userRequest = new UserRequest();

        public UserUserControl()
        {
            InitializeComponent();
        }

        private void UserUserControl_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public static UserUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserUserControl();
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
                    String response = userRequest.CreateRetirement(persalNumberText.Text, IDText.Text, FirstNameText.Text, LastNameText.Text, getDate(), PhyicalAddressText.Text, PostalAddressText.Text, UserRoleBox.Text, GenderBox.Text, RaceBox.Text, Education.getRole());
                    if (response != null)
                    {
                        UserRootObj retirement = JsonConvert.DeserializeObject<UserRootObj>(response);
                        persalNumberText.Text = "";
                        IDText.Text = "";
                        FirstNameText.Text = "";
                        LastNameText.Text = "";
                        PhyicalAddressText.Text = "";
                        PostalAddressText.Text = "";
                        GetAll();
                    }
                }
            }
            else
            {
                String response = userRequest.CreateRetirement(persalNumberText.Text, IDText.Text, FirstNameText.Text, LastNameText.Text, getDate(), PhyicalAddressText.Text, PostalAddressText.Text, UserRoleBox.Text, GenderBox.Text, RaceBox.Text, Education.getRole());
                if (response != null)
                {
                    UserRootObj retirement = JsonConvert.DeserializeObject<UserRootObj>(response);
                    persalNumberText.Text = "";
                    IDText.Text = "";
                    FirstNameText.Text = "";
                    LastNameText.Text = "";
                    PhyicalAddressText.Text = "";
                    PostalAddressText.Text = "";
                    GetAll();
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            persalNumberText.Text = "";
            IDText.Text = "";
            FirstNameText.Text = "";
            LastNameText.Text = "";
            PhyicalAddressText.Text = "";
            PostalAddressText.Text = "";
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
                    String response = userRequest.ReadAppointment(PersalNumberReadtxt.Text, Education.getRole());

                    if (response != null)
                    {
                        getReadObject(response);
                    }
                }
            }
            else
            {
                String response = userRequest.ReadAppointment(PersalNumberReadtxt.Text, Education.getRole());

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
                    if (Education.getRole().Equals("admin"))
                    {
                        String response = userRequest.DeleteAppointment(DeleteUser.Text, Education.getRole());
                        DeleteUser.Text = "";
                        GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete, can Only delete your own Appointment");
                        DeleteUser.Text = "";
                    }
                }
            }
            else
            {
                if (Education.getRole().Equals("admin"))
                {
                    String response = userRequest.DeleteAppointment(DeleteUser.Text, Education.getRole());
                    DeleteUser.Text = "";
                    GetAll();
                }
                else
                {
                    MessageBox.Show("Unable to Delete, Onluy admin can");
                    DeleteUser.Text = "";
                }
            }
        }

        public void GetAll()
        {
            listView2.Items.Clear();
            String userresponse = userRequest.GetAllAppointments("user");
            String addressresponse = userRequest.GetAllAppointments("address");
            String dateAppointedresponse = userRequest.GetAllAppointments("dateAppointed");
            String userDemoresponse = userRequest.GetAllAppointments("userDemo");
            listView2.View = View.Details;

            listView2.GridLines = true;
            if (userresponse != null)
            {
                List<UserObj> UserCollection = JsonConvert.DeserializeObject<List<UserObj>>(userresponse);
                List<AddressObj> AddressCollection = JsonConvert.DeserializeObject<List<AddressObj>>(addressresponse);
                List<DateAppointedObj> DateAppointedCollection = JsonConvert.DeserializeObject<List<DateAppointedObj>>(dateAppointedresponse);
                List<UserDemographyObj> UserDemographyCollection = JsonConvert.DeserializeObject<List<UserDemographyObj>>(userDemoresponse);

                foreach (UserObj pl in UserCollection)
                {
                    int indexStatus = AddressCollection.FindIndex(delegate (AddressObj i) { return i.persal_Number.Equals(pl.persal_Number); });
                    int indexStatus2 = DateAppointedCollection.FindIndex(delegate (DateAppointedObj i) { return i.persal_Number.Equals(pl.persal_Number); });
                    int indexStatus3 = UserDemographyCollection.FindIndex(delegate (UserDemographyObj i) { return i.persal_Number.Equals(pl.persal_Number); });
                    String gender = getDemography(userRequest.ReadGender(UserDemographyCollection.ElementAt(indexStatus3).genderId, Education.getRole()));
                    String race = getDemography(userRequest.ReadRace(UserDemographyCollection.ElementAt(indexStatus3).raceId, Education.getRole()));
                    listView2.Items.Add(new ListViewItem(new string[] { pl.persal_Number,
                                                                        pl.id,
                                                                        pl.first_Names,
                                                                        pl.last_Name,
                                                                        AddressCollection.ElementAt(indexStatus).physicalAddress,
                                                                        AddressCollection.ElementAt(indexStatus).postalAddress,
                                                                        DateAppointedCollection.ElementAt(indexStatus2).date,
                                                                        gender,
                                                                        race
                                                                        }));
                };
            }
        }

        private String getDemography(String response)
        {
            String gender = null;
            if (response == null)
            {
            }
            else
            {
                if (response.Contains("gender"))
                {
                    GenderObj genderDescription = JsonConvert.DeserializeObject<GenderObj>(response);
                    gender = genderDescription.genderDescription;
                }
                else if (response.Contains("race"))
                {
                    RaceObj racerDescription = JsonConvert.DeserializeObject<RaceObj>(response);
                    gender = racerDescription.raceDescription;
                }
            }
            return gender;
        }

        private String getDate()
        {
            string theDate = dateTimePicker1.Value.ToString("dd/MMMM/yyyy");
            return theDate;
        }

        private void getReadObject(String response)
        {
            listView2.Items.Clear();
            UserRootObj user = JsonConvert.DeserializeObject<UserRootObj>(response);
            String persal_Num = user.User.persal_Number;
            String iD = user.User.id;
            String firstName = user.User.first_Names;
            String lastName = user.User.last_Name;
            String physicalAddress = user.Address.physicalAddress;
            String postalAddress = user.Address.postalAddress;
            String dateAppointed = user.DateAppointed.date;
            String userDemoResponse = userRequest.ReadUserDemo(persal_Num, Education.getRole());
            UserDemographyObj userDemo = JsonConvert.DeserializeObject<UserDemographyObj>(userDemoResponse);

            String gender = getDemography(userRequest.ReadGender(userDemo.genderId, Education.getRole()));
            String race = getDemography(userRequest.ReadRace(userDemo.raceId, Education.getRole()));
            listView2.Items.Add(new ListViewItem(new string[] { persal_Num,
                                                                iD,
                                                                firstName,
                                                                lastName,
                                                                physicalAddress,
                                                                postalAddress,
                                                                dateAppointed,
                                                                gender,
                                                                race,
            }));
            persalNumberText.Text = persal_Num;
            IDText.Text = iD;
            FirstNameText.Text = firstName;
            LastNameText.Text = lastName;
            PhyicalAddressText.Text = physicalAddress;
            PostalAddressText.Text = postalAddress;
            PersalNumberReadtxt.Text = persal_Num;
            DeleteUser.Text = persal_Num;
            GenderBox.Text = gender;
            RaceBox.Text = race;
        }

        private void PhyicalAddressText_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PostalAddressText.Enabled = false;
                PostalAddressText.Text = PhyicalAddressText.Text;
            }
            else
            {
                PostalAddressText.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PostalAddressText.Enabled = false;
            }
            else { PostalAddressText.Enabled = true; }
        }
    }
}