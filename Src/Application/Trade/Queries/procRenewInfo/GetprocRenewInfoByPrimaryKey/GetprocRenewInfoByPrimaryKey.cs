using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procRenewInfo.GetprocRenewInfoLoadAll;

namespace Application.Trade.Quiries.procRenewInfo.GetprocRenewInfoByPrimaryKey
{
    /// @author  Shimels Alem proc_Renew_InfoLoadByPrimaryKey stored procedure.

    public class GetprocRenewInfoByPrimaryKey : IRequest<GetprocRenewInfoLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
