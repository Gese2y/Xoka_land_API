


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procMSEBalanceSheet.procMSEBalanceSheetInsert.procMSEBalanceSheetInsertCommand
{

	/// @author  Shimels Alem  proc_MSE_Balance_SheetInsert stored procedure.


	public class procMSEBalanceSheetInsertCommand : IRequest<IList<MSEBalanceSheet_YearAndTIN>>
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
 
 