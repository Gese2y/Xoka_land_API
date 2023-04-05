namespace XOKA.Domain.Entities.Job
{
    public class BusinessOppoForjobCreation
	{
		public System.Guid BUS_OPP_ID { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public string Sector { get; set; }
		public string Sub_Sector { get; set; }
		public string Other_Sector { get; set; }
		public string Objective { get; set; }
		public string Profitable_Percent { get; set; }
		public byte[]? Business_Plan { get; set; }
		public System.DateTime? Date { get; set; }
		public System.Int32? JobOpen_For_ENT { get; set; }
		public System.Int32? Job_Open_For_Job_Seeker { get; set; }
	}
}
