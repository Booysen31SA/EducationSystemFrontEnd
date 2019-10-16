using System;

namespace EducationSystemFrontEnd.Requests.Retirement
{

    public class RootObject
    {
        public RetirementObj retirement { get; set; }
        public StatusObj Status { get; set; }

    }
    public class RetirementObj
    {
        public String persal_Num { get; set; }
        public String iD { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public double payout { get; set; }
    }
    public class StatusObj
    {
        public String persal_Number { get; set; }
        public String request { get; set; }
    }
}
