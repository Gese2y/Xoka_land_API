using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procRenewInfoChange.GetprocRenewInfoChangeLoadAll;

namespace Application.Trade.Quiries.procRenewInfoChange.GetprocRenewInfoChangeLoadByPrimaryKeyID
{
    /// @author  Shimels Alem proc_Renew_Info_ChangeLoadByPrimaryKey_ID stored procedure.

    public class GetprocRenewInfoChangeLoadByPrimaryKeyID : IRequest<GetprocRenewInfoChangeLoadAllListVm>
    {
        public string ID { get; set; }
    }
}
