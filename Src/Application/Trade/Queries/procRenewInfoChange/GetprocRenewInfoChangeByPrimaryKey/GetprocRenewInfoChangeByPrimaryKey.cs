using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procRenewInfoChange.GetprocRenewInfoChangeLoadAll;

namespace Application.Trade.Quiries.procRenewInfoChange.GetprocRenewInfoChangeByPrimaryKey
{
    /// @author  Shimels Alem proc_Renew_Info_ChangeLoadByPrimaryKey stored procedure.

    public class GetprocRenewInfoChangeByPrimaryKey : IRequest<GetprocRenewInfoChangeLoadAllListVm>
    {
        public System.Guid Change_ID { get; set; }
    }
}
