using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Commands.procCollateral.procCollateralUpdate.procCollateralUpdateCommand
{

	/// @author  Shimels Alem  proc_CollateralUpdate stored procedure.

	public class procCollateralUpdateCommand : IRequest<IList<Collateral_CollateralID>>
   {
		public System.Guid Collateral_ID { get; set; }
		public string TIN { get; set; }
		public System.Guid? Loan_ID { get; set; }
		public string Collateral_Type { get; set; }
		public string Code { get; set; }
		public System.Double? Stimated_price { get; set; }
		public string Name { get; set; }
		public string ID_TIN_Number { get; set; }
		public string Remark { get; set; }
		public System.DateTime? Regstration_Date { get; set; }
		public bool? IS_Active { get; set; }
	}
		
		
		 
}

