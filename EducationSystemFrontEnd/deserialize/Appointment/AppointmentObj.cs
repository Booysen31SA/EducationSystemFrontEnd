using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EducationSystemFrontEnd.deserialize.Appointment
{
    public class appointment
    {

        public class Rootobject
        {
            public Appointment appointment { get; set; }
            
            public Dateandtime dateAndTime { get; set; }
            
            public Reason reason { get; set; }
        }

        public class Appointment
        {
            public string persalNumber { get; set; }
            public string appointmentToSee { get; set; }
        }

        public class Dateandtime
        {
            public string persal_Number { get; set; }
            public string date { get; set; }
            public string time { get; set; }
        }

        public class Reason
        {
            public string persal_Number { get; set; }
            public string reason { get; set; }
        }
    }
}
