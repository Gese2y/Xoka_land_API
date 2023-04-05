using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procMKTProdIO.GetprocMKTProdIOLoadAll;

namespace Application.Job.Quiries.procMKTProdIO.GetprocMKTProdIOByPrimaryKey
{
    /// @author  Shimels Alem proc_MKT_Prod_IOLoadByPrimaryKey stored procedure.

    public class GetprocMKTProdIOByPrimaryKey : IRequest<GetprocMKTProdIOLoadAllListVm>
    {
       public System.Guid ID { get; set; }
    }
}
