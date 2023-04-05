namespace XOKA.Domain.Entities.TVET
{
    public class Student
	{
		public System.Guid ID { get; set; }
		public string Code { get; set; }
		public string Type { get; set; }
		public string Fname { get; set; }
		public string Lname { get; set; }
		public string Mame { get; set; }
		public System.DateTime Reg_Date { get; set; }
		public bool? Applicatuion_Submitted { get; set; }
		public bool? Is_Approved { get; set; }
		public System.Guid? Licence_ID { get; set; }
	}
}
