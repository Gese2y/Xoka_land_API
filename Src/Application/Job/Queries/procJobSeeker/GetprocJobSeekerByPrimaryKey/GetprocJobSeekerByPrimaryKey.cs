using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procJobSeeker.GetprocJobSeekerLoadAll;

namespace Application.Job.Quiries.procJobSeeker.GetprocJobSeekerByPrimaryKey
{
    /// @author  Shimels Alem proc_Job_SeekerLoadByPrimaryKey stored procedure.

    public class GetprocJobSeekerByPrimaryKey : IRequest<GetprocJobSeekerLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
