using System;

namespace XOKA.Domain.Entities.TVET
{
    public class View_TVET_Result_Pop_UP
	{
        public Guid ID { get; set; }
        public string Student_Code { get; set; }
        public string Student_Name { get; set; }
        public string Lname { get; set; }
        public string Mname { get; set; }
        public string Course_Name { get; set; }
        public int Credit_Hour { get; set; }
        public string Provider { get; set; }
        public string Venue { get; set; }
        public string Course_Code { get; set; }
        public Guid EID { get; set; }
    }
}
