

namespace XOKA.Domain.Entities.Tax
{
    public class _TIN
	{
		public System.Guid ID { get; set; }
		public long? TIN { get; set; }
		public System.DateTime? Date_Issued { get; set; }
		public string Certificate_Code { get; set; }
		public string Certificate_NO { get; set; }
		public string Remark { get; set; }
		public bool? IsActive { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public byte[] Date_log { get; set; }
	}
}
