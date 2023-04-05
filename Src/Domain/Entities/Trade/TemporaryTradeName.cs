namespace XOKA.Domain.Entities.Trade
{
    public class TemporaryTradeName
	{
		public System.Guid Temp_Name_ID { get; set; }
		public string Code { get; set; }
		public string Name_EN { get; set; }
		public string Name_AM { get; set; }
		public string Status { get; set; }
		public string Latter_Number { get; set; }
		public System.DateTime? Registration_Date { get; set; }
		public System.DateTime? Expire_Date { get; set; }
		public System.Guid? Parent_Name { get; set; }
		public string Child_Name { get; set; }
		public System.Guid? Licence_ID { get; set; }
	}
}
