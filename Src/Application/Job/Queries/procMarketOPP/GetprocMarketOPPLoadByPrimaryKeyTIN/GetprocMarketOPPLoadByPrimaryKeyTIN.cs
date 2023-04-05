using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procMarketOPP.GetprocMarketOPPLoadAll;

namespace Application.Job.Quiries.procMarketOPP.GetprocMarketOPPLoadByPrimaryKeyTIN
{
    /// @author  Shimels Alem proc_Market_OPPLoadByPrimaryKey_TIN stored procedure.

    public class GetprocMarketOPPLoadByPrimaryKeyTIN : IRequest<GetprocMarketOPPLoadAllListVm>
    {
        public string TIN { get; set; }
    }
}
