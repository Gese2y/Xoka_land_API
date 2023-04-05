using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Commands.procLoan.procLoanUpdate.procLoanUpdateCommand
{

	/// @author  Shimels Alem  proc_LoanUpdate stored procedure.

	public class procLoanUpdateCommand : IRequest<IList<Loan_LoanId>>
   {
		public System.Guid Loan_Id { get; set; }
		public System.Guid? ApplicationCodeCreadit { get; set; }
		public long? Member_Id { get; set; }
		public System.Guid? MF { get; set; }
		public System.Double? Amount { get; set; }
		public System.DateTime? Request_Date { get; set; }
		public bool? Approved { get; set; }
		public System.DateTime? Approved_Date { get; set; }
		public string Manual_Approved_By { get; set; }
		public bool? Submited { get; set; }
		public string Loan_Status { get; set; }
	}
		
		
		 
}

