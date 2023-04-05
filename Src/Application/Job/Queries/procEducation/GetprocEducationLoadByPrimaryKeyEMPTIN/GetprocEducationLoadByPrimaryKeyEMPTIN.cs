using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procEducation.GetprocEducationLoadAll;

namespace Application.Job.Quiries.procEducation.GetprocEducationLoadByPrimaryKeyEMPTIN
{
    /// @author  Shimels Alem proc_EducationLoadByPrimaryKey_EMP_TIN stored procedure.

    public class GetprocEducationLoadByPrimaryKeyEMPTIN : IRequest<GetprocEducationLoadAllListVm>
    {
        public string EMP_TIN { get; set; }
    }
}
