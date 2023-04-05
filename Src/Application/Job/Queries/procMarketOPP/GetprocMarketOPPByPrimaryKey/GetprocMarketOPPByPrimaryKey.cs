using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procMarketOPP.GetprocMarketOPPLoadAll;

namespace Application.Job.Quiries.procMarketOPP.GetprocMarketOPPByPrimaryKey
{
    /// @author  Shimels Alem proc_Market_OPPLoadByPrimaryKey stored procedure.

    public class GetprocMarketOPPByPrimaryKey : IRequest<GetprocMarketOPPLoadAllListVm>
    {
        public System.Guid OPP_ID { get; set; }
    }
}
