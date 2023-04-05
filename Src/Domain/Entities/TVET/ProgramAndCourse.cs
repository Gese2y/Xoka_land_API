namespace XOKA.Domain.Entities.TVET
{
    public class ProgramAndCourse
	{
		public System.Guid P_C_ID { get; set; }
		public string Program_code { get; set; }
		public string Course_ID { get; set; }
		public bool? IS_Active { get; set; }
		public string Remarks { get; set; }
	}
}
