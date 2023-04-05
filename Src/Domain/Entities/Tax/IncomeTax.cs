

namespace XOKA.Domain.Entities.Tax
{
    public class IncomeTax
	{
		public System.Guid ID { get; set; }
		public System.Guid TIN { get; set; }
		public System.DateTime Year { get; set; }
		public System.DateTime? Date_Paid { get; set; }
		public string Type_Income_Tax { get; set; }
		public int? Amount { get; set; }
	}
}
