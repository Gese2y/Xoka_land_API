using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procOwnerInfo.GetprocOwnerInfoLoadAll;

namespace Application.Trade.Quiries.procOwnerInfo.GetprocOwnerInfoByPrimaryKey
{
    /// @author  Shimels Alem proc_Owner_InfoLoadByPrimaryKey stored procedure.

    public class GetprocOwnerInfoByPrimaryKey : IRequest<GetprocOwnerInfoLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
