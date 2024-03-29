﻿using EducationSystemFrontEnd.Requests.Login;
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
            if (PersalNumberTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0)
            {
                LoginRequest loginRequest = new LoginRequest();
                String user = loginRequest.CredentialCheck(PersalNumberTextBox.Text);
                CredCheck(user);
            }
            else { MessageBox.Show("Please Fill in the required fields", "Not enough Information"); }
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
                    MessageBox.Show(this, "Incorrect Details, Please Contact ADMIN", "Invaild details");
                }
            }
        }
    }
}
