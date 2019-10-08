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
        public DateAndTimeObj DateAndTime { get; set; }
        public ReasonObj ReasonObj { get; set; }
    }
    public class AppointmentObj
    {
        private String persalNumber;
        private String appointmentToSee;
        public string PersalNumber { get => persalNumber; set => persalNumber = value; }
        public string AppointmentToSee { get => appointmentToSee; set => appointmentToSee = value; }
    }
    public class DateAndTimeObj
    {
        public String persal_Number { get; set; }
        public String date { get; set; }
        public String time { get; set; }
    }
    public class ReasonObj
    {
        public String persal_Number { get; set; }
        public String reason { get; set; }
    }
}
