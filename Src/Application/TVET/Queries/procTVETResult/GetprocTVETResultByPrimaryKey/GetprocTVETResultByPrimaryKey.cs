using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procTVETResult.GetprocTVETResultLoadAll;

namespace Application.TVET.Quiries.procTVETResult.GetprocTVETResultByPrimaryKey
{
    /// @author  Shimels Alem proc_TVET_ResultLoadByPrimaryKey stored procedure.

    public class GetprocTVETResultByPrimaryKey : IRequest<GetprocTVETResultLoadAllListVm>
    {
        public System.Guid RId { get; set; }
    }
}
