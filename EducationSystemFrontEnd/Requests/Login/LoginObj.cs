using System;

namespace EducationSystemFrontEnd.Requests.Login
{
    class LoginObj
    {
        private String persal_Number;
        private String userRole;
        private String userPassword;

        public string Persal_Number { get => persal_Number; set => persal_Number = value; }
        public string UserRole { get => userRole; set => userRole = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
    }

}
