using EducationSystemFrontEnd.Requests.Login;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace EducationSystemFrontEnd.GUI.LoginForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginRequest loginRequest = new LoginRequest();
            String user = loginRequest.CredentialCheck(PersalNumberTextBox.Text);
            CredCheck(user);
        }

        private void CredCheck(String userJson)
        {
            if (userJson == null)
            {

            }
            else
            {
                LoginObj loginCredential = JsonConvert.DeserializeObject<LoginObj>(userJson);
                String pumber = loginCredential.Persal_Number;
                String role = loginCredential.UserRole;
                String pword = loginCredential.UserPassword;
                if (pumber == PersalNumberTextBox.Text && pword == passwordTextBox.Text)
                {
                    EducationSystem educationSystem = new EducationSystem();
                    educationSystem.updateCred(pumber, role, pword);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Incorrect Details");
                }
            }
        }
    }
}
