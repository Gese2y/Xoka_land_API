using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Tax.Quiries.procShareHolderDetail.GetprocShareHolderDetailLoadAll;

namespace Application.Tax.Quiries.procShareHolderDetail.GetprocShareHolderDetailByPrimaryKey
{
    /// @author  Shimels Alem proc_Share_Holder_DetailLoadByPrimaryKey stored procedure.

    public class GetprocShareHolderDetailByPrimaryKey : IRequest<GetprocShareHolderDetailLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
