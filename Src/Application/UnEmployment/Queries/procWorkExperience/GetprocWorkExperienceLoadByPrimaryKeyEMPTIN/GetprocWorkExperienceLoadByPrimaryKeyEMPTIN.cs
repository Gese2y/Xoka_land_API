using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.UnEmployment.Quiries.procWorkExperience.GetprocWorkExperienceLoadAll;

namespace Application.UnEmployment.Quiries.procWorkExperience.GetprocWorkExperienceLoadByPrimaryKeyEMPTIN
{
    /// @author  Shimels Alem proc_Work_ExperienceLoadByPrimaryKey_EMP_TIN stored procedure.

    public class GetprocWorkExperienceLoadByPrimaryKeyEMPTIN : IRequest<GetprocWorkExperienceLoadAllListVm>
    {
        public string EMP_TIN { get; set; }
    }
}
