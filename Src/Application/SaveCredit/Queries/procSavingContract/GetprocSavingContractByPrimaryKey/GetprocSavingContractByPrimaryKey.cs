using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.SaveCredit.Quiries.procSavingContract.GetprocSavingContractLoadAll;

namespace Application.SaveCredit.Quiries.procSavingContract.GetprocSavingContractByPrimaryKey
{
    /// @author  Shimels Alem proc_Saving_ContractLoadByPrimaryKey stored procedure.

    public class GetprocSavingContractByPrimaryKey : IRequest<GetprocSavingContractLoadAllListVm>
    {
        public System.Guid contract_id { get; set; }
    }
}
