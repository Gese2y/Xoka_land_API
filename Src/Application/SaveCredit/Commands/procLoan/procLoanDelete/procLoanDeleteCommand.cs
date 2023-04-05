 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Commands.procLoan.procLoanDelete.procLoanDeleteCommand
{

    // @author  Shimels Alem  proc_LoanDelete stored procedure.

    public class procLoanDeleteCommand : IRequest<IList<Loan_LoanId>>
    {
        public System.Guid Loan_Id { get; set; }
    }
		
     
		
		 
}
 
 