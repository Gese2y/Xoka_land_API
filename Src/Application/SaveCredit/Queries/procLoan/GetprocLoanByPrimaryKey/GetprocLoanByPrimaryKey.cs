using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.SaveCredit.Quiries.procLoan.GetprocLoanLoadAll;

namespace Application.SaveCredit.Quiries.procLoan.GetprocLoanByPrimaryKey
{
    /// @author  Shimels Alem proc_LoanLoadByPrimaryKey stored procedure.

    public class GetprocLoanByPrimaryKey : IRequest<GetprocLoanLoadAllListVm>
    {
        public System.Guid Loan_Id { get; set; }
    }
}
