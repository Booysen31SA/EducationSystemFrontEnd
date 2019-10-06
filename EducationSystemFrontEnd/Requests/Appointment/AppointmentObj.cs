using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationSystemFrontEnd.Requests.Appointment
{
    public class RootObject
    {
     public AppointmentObj Appointment { get; set; }
    }
    public class AppointmentObj
    {
        public string PersalNumber { get; set; }
        public string AppointmentToSee { get; set; }
    }
}
