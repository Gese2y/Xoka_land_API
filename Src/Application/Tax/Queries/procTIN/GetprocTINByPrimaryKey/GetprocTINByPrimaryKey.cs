using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Tax.Quiries.procTIN.GetprocTINLoadAll;

namespace Application.Tax.Quiries.procTIN.GetprocTINByPrimaryKey
{
    /// @author  Shimels Alem proc_TINLoadByPrimaryKey stored procedure.

    public class GetprocTINByPrimaryKey : IRequest<GetprocTINLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
