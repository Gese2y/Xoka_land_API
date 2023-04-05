namespace XOKA.Domain.Entities.SaveCredit
{
    public class Instalments
	{
		public System.Guid contract_id { get; set; }
		public System.Int32 number { get; set; }
		public System.DateTime expected_date { get; set; }
		public System.Double interest_repayment { get; set; }
		public System.Double capital_repayment { get; set; }
		public System.Double paid_interest { get; set; }
		public System.Double paid_capital { get; set; }
		public System.Double fees_unpaid { get; set; }
		public System.DateTime? paid_date { get; set; }
		public System.Double Total_paid_fees { get; set; }
		public string comment { get; set; }
		public bool pending { get; set; }
		public System.DateTime start_date { get; set; }
		public System.Double commission { get; set; }
		public System.Double paid_commission { get; set; }
	}
}
