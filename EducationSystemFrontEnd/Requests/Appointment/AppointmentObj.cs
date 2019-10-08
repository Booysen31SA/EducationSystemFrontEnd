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
        private String persalNumber;
        private String appointmentToSee;
        public string PersalNumber { get => persalNumber; set => persalNumber = value; }
        public string AppointmentToSee { get => appointmentToSee; set => appointmentToSee = value; }
    }
}
