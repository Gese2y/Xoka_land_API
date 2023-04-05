using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procBusinessActivity.GetprocBusinessActivityLoadAll;

namespace Application.Trade.Quiries.procBusinessActivity.GetprocBusinessActivityByPrimaryKey
{
    /// @author  Shimels Alem proc_Business_ActivityLoadByPrimaryKey stored procedure.

    public class GetprocBusinessActivityByPrimaryKey : IRequest<GetprocBusinessActivityLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
