namespace XOKA.Domain.Entities.dbo
{
    public class MKTProdIO
	{
        public System.Guid OPP_ID { get; set; }
        public long? TIN { get; set; }
        public string Opp_Type { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Contact_Person { get; set; }
        public string Region { get; set; }
        public string Zone { get; set; }
        public string Woreda { get; set; }
        public string Hous_No { get; set; }
        public System.Int32? JobOpen_For_ENT { get; set; }
        public System.Int32? Job_Open_For_Job_Seeker { get; set; }
        public System.Guid? Licence_ID { get; set; } 
	}
}
