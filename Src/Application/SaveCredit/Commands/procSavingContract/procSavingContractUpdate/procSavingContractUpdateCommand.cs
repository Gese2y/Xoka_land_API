using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Commands.procSavingContract.procSavingContractUpdate.procSavingContractUpdateCommand
{

	/// @author  Shimels Alem  proc_Saving_ContractUpdate stored procedure.

	public class procSavingContractUpdateCommand : IRequest<IList<SavingContract_contractid>>
   {
		public System.Guid contract_id { get; set; }
		public System.Guid? Loan_id { get; set; }
		public string contract_code { get; set; }
		public System.DateTime creation_date { get; set; }
		public System.DateTime start_date { get; set; }
		public System.DateTime close_date { get; set; }
		public bool closed { get; set; }
		public string Loan_Contract_status { get; set; }
		public string loan_purpose { get; set; }
		public string comments { get; set; }
		public System.DateTime? preferred_first_installment_date { get; set; }
		public System.Guid? Licence_ID { get; set; }
	}
		
		
		 
}

