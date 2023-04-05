namespace XOKA.Domain.Entities.Trade
{
    public class CommercialRegistration
	{
		public string COM_REG_Number { get; set; }
		public string TIN { get; set; }
		public System.Guid? Temp_Name_ID { get; set; }
		public string Rgistration__Name_AM { get; set; }
		public string Rgistration__Name_EN { get; set; }
		public System.DateTime? Rgistration_Date_EN { get; set; }
		public System.DateTime? Rgistration_Date_AM { get; set; }
		public bool? IS_GM { get; set; }
		public System.DateTime? modified_Date { get; set; }
	}
}
