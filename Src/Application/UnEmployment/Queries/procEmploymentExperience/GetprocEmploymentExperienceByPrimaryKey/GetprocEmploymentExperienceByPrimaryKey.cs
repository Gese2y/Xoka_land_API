using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.UnEmployment.Quiries.procEmploymentExperience.GetprocEmploymentExperienceLoadAll;

namespace Application.UnEmployment.Quiries.procEmploymentExperience.GetprocEmploymentExperienceByPrimaryKey
{
    /// @author  Shimels Alem proc_Employment_ExperienceLoadByPrimaryKey stored procedure.

    public class GetprocEmploymentExperienceByPrimaryKey : IRequest<GetprocEmploymentExperienceLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
