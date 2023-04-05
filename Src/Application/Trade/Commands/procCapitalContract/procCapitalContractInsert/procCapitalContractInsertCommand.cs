


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procCapitalContract.procCapitalContractInsert.procCapitalContractInsertCommand
{

	/// @author  Shimels Alem  proc_Capital_ContractInsert stored procedure.


	public class procCapitalContractInsertCommand : IRequest<IList<CapitalContract_ContractID>>
    {
		public System.Guid Contract_ID { get; set; }
		public System.Guid? Application_for_G_ID { get; set; }
		public string NSE_TIN { get; set; }
		public string Contract_Title { get; set; }
		public string Contract_NO { get; set; }
		public System.Guid? Organization_ID { get; set; }
		public System.Double? Total_Contract_Amount { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public System.Guid? Doc_ID { get; set; }
		public bool? Is_Active { get; set; }
	}
		
		
		 
}
 
 