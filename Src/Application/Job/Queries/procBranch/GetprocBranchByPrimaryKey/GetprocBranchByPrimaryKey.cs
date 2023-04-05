using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procBranch.GetprocBranchLoadAll;

namespace Application.Job.Quiries.procBranch.GetprocBranchByPrimaryKey
{
    /// @author  Shimels Alem proc_BranchLoadByPrimaryKey stored procedure.

    public class GetprocBranchByPrimaryKey : IRequest<GetprocBranchLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
