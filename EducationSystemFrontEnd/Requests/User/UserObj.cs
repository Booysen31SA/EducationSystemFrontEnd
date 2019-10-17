using System;

namespace EducationSystemFrontEnd.Requests.User
{
    public class UserRootObj
    {
        public UserObj User { get; set; }
        public AddressObj Address { get; set; }
        public DateAppointedObj DateAppointed { get; set; }
        public UserDemographyObj UserDemography { get; set; }
    }

    public class UserObj
    {
        public String persal_Number { get; set; }
        public String id { get; set; }
        public String first_Names { get; set; }
        public String last_Name { get; set; }
    }

    public class AddressObj
    {
        public String persal_Number { get; set; }
        public String physicalAddress { get; set; }
        public String postalAddress { get; set; }
    }

    public class DateAppointedObj
    {
        public String persal_Number { get; set; }
        public String date { get; set; }
    }

    public class UserDemographyObj
    {
        public String persal_Number { get; set; }
        public String genderId { get; set; }
        public String raceId { get; set; }
    }

    public class GenderObj
    {
        public String genderId { get; set; }
        public String genderDescription { get; set; }
    }

    public class RaceObj
    {
        public String raceId { get; set; }
        public String raceDescription { get; set; }
    }
}