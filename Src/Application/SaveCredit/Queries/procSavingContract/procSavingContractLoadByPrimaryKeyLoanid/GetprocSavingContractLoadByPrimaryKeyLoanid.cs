using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.SaveCredit.Quiries.procSavingContract.GetprocSavingContractLoadAll;

namespace Application.SaveCredit.Quiries.procSavingContract.GetprocSavingContractLoadByPrimaryKeyLoanid
{
    /// @author  Shimels Alem proc_Saving_ContractLoadByPrimaryKey_Loan_id stored procedure.

    public class GetprocSavingContractLoadByPrimaryKeyLoanid : IRequest<GetprocSavingContractLoadAllListVm>
    {
        public System.Guid Loan_id { get; set; }
    }
}
