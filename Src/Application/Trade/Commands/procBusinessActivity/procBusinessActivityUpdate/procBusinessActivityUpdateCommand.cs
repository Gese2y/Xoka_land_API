using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procBusinessActivity.procBusinessActivityUpdate.procBusinessActivityUpdateCommand
{

	/// @author  Shimels Alem  proc_Business_ActivityUpdate stored procedure.

	public class procBusinessActivityUpdateCommand : IRequest<IList<BusinessActivity_Code>>
   {
		public string Code { get; set; }
		public string TIN { get; set; }
		public string Bus_Activity_code { get; set; }
		public string Activity_Name { get; set; }
	}
		
		
		 
}

