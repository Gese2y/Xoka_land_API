namespace XOKA.Domain.Entities.Trade
{
    public class CapitalContract
	{
		public System.Guid Contract_ID { get; set; }
		public System.Guid? Application_for_G_ID { get; set; }
		public string NSE_TIN { get; set; }
		public string Contract_Title { get; set; }
		public string Contract_NO { get; set; }
		public System.Guid? Organization_ID { get; set; }
		public System.Double? Total_Contract_Amount { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public System.Guid? Doc_ID { get; set; }
		public bool? Is_Active { get; set; }
	}
}
