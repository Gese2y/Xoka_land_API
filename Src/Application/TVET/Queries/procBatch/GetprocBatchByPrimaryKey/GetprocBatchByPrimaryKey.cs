using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procBatch.GetprocBatchLoadAll;

namespace Application.TVET.Quiries.procBatch.GetprocBatchByPrimaryKey
{
    /// @author  Shimels Alem proc_BatchLoadByPrimaryKey stored procedure.

    public class GetprocBatchByPrimaryKey : IRequest<GetprocBatchLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
