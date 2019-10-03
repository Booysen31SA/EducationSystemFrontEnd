using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationSystemFrontEnd.deserialize.Appointment
{
    class UniversalAppointment
    {
        public List<Appointment> appointments { get; set; }
    }

    public class Appointment
    {
        public String persalNumber { get; set; }
        public String appointmentToSee { get; set; }
    }
    public class DateAndTime
    {
        public String persal_Number { get; set; }
        public String date { get; set; }
        public String time { get; set; }
    }
    public class reason
    {
        public String persal_Number { get; set; }
        public String Reason { get; set; }
    }
  
}
