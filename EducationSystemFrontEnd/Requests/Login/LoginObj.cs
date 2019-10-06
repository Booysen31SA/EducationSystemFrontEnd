using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationSystemFrontEnd.Requests.Login
{
    class LoginObj
    {
        public Logindata loginData { get; set; }
    }
    public class Logindata
    {
        public String persal_Number { get; set; }
        public String userRole { get; set; }
        public String userPassword { get; set; }
    }
    }
