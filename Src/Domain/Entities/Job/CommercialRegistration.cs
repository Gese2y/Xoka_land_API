namespace XOKA.Domain.Entities.Job
{
    public class CommercialRegistration
	{
		public string COM_REG_Number { get; set; }
		public long TIN { get; set; }
		public System.Guid? Temp_Name_ID { get; set; }
		public string Rgistration__Name_AM { get; set; }
		public string Rgistration__Name_EN { get; set; }
		public System.DateTime? Rgistration_Date_EN { get; set; }
		public System.DateTime? Rgistration_Date_AM { get; set; }
		public byte[] IS_GM { get; set; }
		public System.DateTime? modified_Date { get; set; }
	}
}
