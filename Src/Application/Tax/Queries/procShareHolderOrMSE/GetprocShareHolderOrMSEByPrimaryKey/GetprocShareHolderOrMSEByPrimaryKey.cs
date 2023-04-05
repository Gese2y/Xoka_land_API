using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Tax.Quiries.procShareHolderOrMSE.GetprocShareHolderOrMSELoadAll;

namespace Application.Tax.Quiries.procShareHolderOrMSE.GetprocShareHolderOrMSEByPrimaryKey
{
    /// @author  Shimels Alem [proc_Share_Holder(MSE)LoadByPrimaryKey] stored procedure.

    public class GetprocShareHolderOrMSEByPrimaryKey : IRequest<GetprocShareHolderOrMSELoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
