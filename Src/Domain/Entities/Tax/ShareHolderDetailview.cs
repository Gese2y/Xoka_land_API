

namespace XOKA.Domain.Entities.Tax
{
    public class ShareHolderDetailview
	{
		public System.Guid ID { get; set; }
		public string TIN { get; set; }
		public string Shere_Type { get; set; }
		public System.DateTime? Transfer_Date { get; set; }
		public string DAR_NO { get; set; }
		public int? No_Share { get; set; }
		public System.Double? Share_Price { get; set; }
		public int? Total_Share { get; set; }
		public System.Guid? Doc_ID { get; set; }
		public string Full_Name { get; set; }
		public string YEAR { get; set; }
		public System.Guid? Parent { get; set; }
		public System.Guid? Licence_Id { get; set; }
		public bool? IS_Current { get; set; }
		public string Kebele_ID { get; set; }
		public bool Is_Manager { get; set; }
	}
}
