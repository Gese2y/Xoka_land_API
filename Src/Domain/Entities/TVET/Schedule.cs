namespace XOKA.Domain.Entities.TVET
{
    public class Schedule
	{
		public System.Guid SID { get; set; }
		public System.Guid? EID { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public System.TimeSpan? Start_Hour { get; set; }
		public System.TimeSpan? End_Hour { get; set; }
		public string Course_Code { get; set; }
		public System.Guid? Instructor_ID { get; set; }
		public string Venue { get; set; }
	}
}
