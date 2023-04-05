namespace XOKA.Domain.Entities.SaveCredit
{
    public class ApplicationForCreadit
	{
		public System.Guid ID { get; set; }
		public string TIN { get; set; }
		public string Application { get; set; }
		public System.Double? Amount { get; set; }
		public System.Guid? Doc_ID { get; set; }
		public bool? IS_Disprove { get; set; }
	}
}
