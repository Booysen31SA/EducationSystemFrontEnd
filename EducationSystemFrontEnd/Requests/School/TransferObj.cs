using System;

namespace EducationSystemFrontEnd.Requests.School
{
    public class RootObject
    {
        public TransferObj Transfer { get; set; }
        public Status status { get; set; }
    }

    public class TransferObj
    {
        public String persalNumber { get; set; }
        public String previousSchool { get; set; }
        public String schoolName { get; set; }
        public int teacherAmount { get; set; }
    }

    public class Status
    {
        public String persal_Number { get; set; }
        public String statusRequest { get; set; }
    }
}