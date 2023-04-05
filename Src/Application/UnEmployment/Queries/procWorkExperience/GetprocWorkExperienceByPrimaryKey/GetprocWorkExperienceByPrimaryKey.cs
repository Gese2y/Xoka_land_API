using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.UnEmployment.Quiries.procWorkExperience.GetprocWorkExperienceLoadAll;

namespace Application.UnEmployment.Quiries.procWorkExperience.GetprocWorkExperienceByPrimaryKey
{
    /// @author  Shimels Alem proc_Work_ExperienceLoadByPrimaryKey stored procedure.

    public class GetprocWorkExperienceByPrimaryKey : IRequest<GetprocWorkExperienceLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
