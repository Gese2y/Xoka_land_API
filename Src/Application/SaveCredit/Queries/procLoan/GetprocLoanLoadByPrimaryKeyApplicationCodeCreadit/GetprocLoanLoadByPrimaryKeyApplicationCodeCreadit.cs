using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.SaveCredit.Quiries.procLoan.GetprocLoanLoadAll;

namespace Application.SaveCredit.Quiries.procLoan.GetprocLoanLoadByPrimaryKeyApplicationCodeCreadit
{
    /// @author  Shimels Alem proc_LoanLoadByPrimaryKey_ApplicationCodeCreadit stored procedure.

    public class GetprocLoanLoadByPrimaryKeyApplicationCodeCreadit : IRequest<GetprocLoanLoadAllListVm>
    {
        public System.Guid ApplicationCodeCreadit { get; set; }
    }
}
