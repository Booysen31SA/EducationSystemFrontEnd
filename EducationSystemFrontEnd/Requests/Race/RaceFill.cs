using System;

namespace EducationSystemFrontEnd.Requests.Race
{
    public class RaceFill
    {
        public String genderId { get; set; }
        public String genderDescription { get; set; }
    }
    public class getAllGenders
    {
        private readonly String AppointmentURL = "http://localhost:8080/gender";
    }

}
