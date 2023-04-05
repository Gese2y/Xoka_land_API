using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procMSEBalanceSheet.procMSEBalanceSheetUpdate.procMSEBalanceSheetUpdateCommand
{

	/// @author  Shimels Alem  proc_MSE_Balance_SheetUpdate stored procedure.

	public class procMSEBalanceSheetUpdateCommand : IRequest<IList<MSEBalanceSheet_YearAndTIN>>
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

