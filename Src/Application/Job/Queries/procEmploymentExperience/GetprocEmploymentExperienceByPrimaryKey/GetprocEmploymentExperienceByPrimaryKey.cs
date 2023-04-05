using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procEmploymentExperience.GetprocEmploymentExperienceLoadAll;

namespace Application.Job.Quiries.procEmploymentExperience.GetprocEmploymentExperienceByPrimaryKey
{
    /// @author  Shimels Alem proc_Employment_ExperienceLoadByPrimaryKey stored procedure.

    public class GetprocEmploymentExperienceByPrimaryKey : IRequest<GetprocEmploymentExperienceLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
