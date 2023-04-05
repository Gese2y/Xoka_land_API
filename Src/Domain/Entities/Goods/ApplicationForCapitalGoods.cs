namespace XOKA.Domain.Entities.Goods
{
    public class ApplicationForCapitalGoods
	{
		public System.Guid ID { get; set; }
		public System.Guid? Licence_Id { get; set; }
		public long? TIN { get; set; }
		public string Application { get; set; }
		public System.Double? Amount { get; set; }
		public System.Guid? Doc_ID { get; set; }
		public bool? IS_Disprove { get; set; }

	}
}
