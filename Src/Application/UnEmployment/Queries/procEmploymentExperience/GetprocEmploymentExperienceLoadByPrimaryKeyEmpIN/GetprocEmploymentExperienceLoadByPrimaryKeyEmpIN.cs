using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.UnEmployment.Quiries.procEmploymentExperience.GetprocEmploymentExperienceLoadAll;

namespace Application.UnEmployment.Quiries.procEmploymentExperience.GetprocEmploymentExperienceLoadByPrimaryKeyEmpIN
{
    /// @author  Shimels Alem proc_Employment_ExperienceLoadByPrimaryKey_Emp_IN stored procedure.

    public class GetprocEmploymentExperienceLoadByPrimaryKeyEmpIN : IRequest<GetprocEmploymentExperienceLoadAllListVm>
    {
        public string EMP_TIN { get; set; }
    }
}
