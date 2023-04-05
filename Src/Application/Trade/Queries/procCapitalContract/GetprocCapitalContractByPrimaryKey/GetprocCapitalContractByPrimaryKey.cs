using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procCapitalContract.GetprocCapitalContractLoadAll;

namespace Application.Trade.Quiries.procCapitalContract.GetprocCapitalContractByPrimaryKey
{
    /// @author  Shimels Alem proc_Capital_ContractLoadByPrimaryKey stored procedure.

    public class GetprocCapitalContractByPrimaryKey : IRequest<GetprocCapitalContractLoadAllListVm>
    {
        public System.Guid Contract_ID { get; set; }
    }
}
