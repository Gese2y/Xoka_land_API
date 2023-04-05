using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procBusinessCode.GetprocBusinessCodeLoadAll;

namespace Application.Trade.Quiries.procBusinessCode.GetprocBusinessCodeByPrimaryKey
{
    /// @author  Shimels Alem proc_Business_CodeLoadByPrimaryKey stored procedure.

    public class GetprocBusinessCodeByPrimaryKey : IRequest<GetprocBusinessCodeLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
