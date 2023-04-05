namespace XOKA.Domain.Entities.Tax
{
    public class TINAdress
	{
		public System.Guid ID { get; set; }
		public string TIN { get; set; }
		public System.Guid Region { get; set; }
		public System.Guid Zone { get; set; }
		public System.Guid Woreda { get; set; }
		public string kebele { get; set; }
		public string House_Number { get; set; }
		public bool? IS_Active { get; set; }
		public System.Guid? Parent { get; set; }

	}
}
