using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procEducation.GetprocEducationLoadAll;

namespace Application.Job.Quiries.procEducation.GetprocEducationByPrimaryKey
{
    /// @author  Shimels Alem proc_EducationLoadByPrimaryKey stored procedure.

    public class GetprocEducationByPrimaryKey : IRequest<GetprocEducationLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
