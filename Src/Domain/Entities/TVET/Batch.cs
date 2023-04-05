namespace XOKA.Domain.Entities.TVET
{
    public class Batch
	{
		public string Code { get; set; }
		public string provider_Code { get; set; }
		public string Program_Code { get; set; }
		public int Year { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public bool? is_Active { get; set; }
	}
}
