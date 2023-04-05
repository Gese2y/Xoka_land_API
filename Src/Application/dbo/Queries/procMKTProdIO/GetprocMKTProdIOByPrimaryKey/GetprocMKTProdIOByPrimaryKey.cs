using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.dbo.Quiries.procMKTProdIO.GetprocMKTProdIOLoadAll;

namespace Application.dbo.Quiries.procMKTProdIO.GetprocMKTProdIOByPrimaryKey
{
    /// @author  Shimels Alem proc_MKT_Prod_IOLoadByPrimaryKey_OPP_ID stored procedure.

    public class GetprocMKTProdIOByPrimaryKey : IRequest<GetprocMKTProdIOLoadAllListVm>
    {
        public System.Guid Opp_ID { get; set; }
    }
}
