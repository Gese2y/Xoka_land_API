using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.DAR.Quiries.procDAR.GetprocDARLoadAll;

namespace Application.DAR.Quiries.procDAR.GetprocDARByPrimaryKey
{
    /// @author  Shimels Alem proc_DARLoadByPrimaryKey stored procedure.

    public class GetprocDARByPrimaryKey : IRequest<GetprocDARLoadAllListVm>
    {
        public string DAR_NO { get; set; }
    }
}
