namespace XOKA.Domain.Entities.Job
{
    public class MSEBalanceSheet
	{
		public int Year { get; set; }
		public string TIN { get; set; }
		public double? Asset_Value_Birr { get; set; }
		public double? Liability_Value_birr { get; set; }
		public double? Owners_Equity_Value_Birr { get; set; }
		public double? Turn_Over_Birr { get; set; }
		public int? Taxable_Income { get; set; }
		public int? Profit_Income { get; set; }
		public int? Net_Income { get; set; }
		public bool? Audited { get; set; }
		public string Remark { get; set; }

	}
}
