using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procJob_Match.GetprocJob_MatchLoadAll;

namespace Application.Job.Quiries.procJob_Match.GetprocJob_MatchByPrimaryKey
{
    /// @author  Shimels Alem proc_MSE_EmployeeLoadByPrimaryKey stored procedure.

    public class GetprocJob_MatchByPrimaryKey : IRequest<GetprocJob_MatchLoadAllListVm>
    {
        public System.Guid Job_Match_ID { get; set; }
    }
}
