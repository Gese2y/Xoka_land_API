using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Tax.Quiries.procShareHolderDetail.GetprocShareHolderDetailLoadAllview;

namespace Application.Tax.Quiries.procShareHolderDetail.GetprocShareHolderDetailviewByPrimaryKey
{
    /// @author  Shimels Alem proc_Share_Holder_DetailLoadByPrimaryKey stored procedure.

    public class GetprocShareHolderDetailviewByPrimaryKey : IRequest<GetprocShareHolderDetailLoadAllviewListVm>
    {
        public System.Guid? Licence_Id { get; set; }
    }
}
