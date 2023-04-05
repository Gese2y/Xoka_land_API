using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procEnterpriseGradeRenewal.GetprocEnterpriseGradeRenewalLoadAll;

namespace Application.Job.Quiries.procEnterpriseGradeRenewal.GetprocEnterpriseGradeRenewalByPrimaryKey
{
    /// @author  Shimels Alem proc_Job_SeekerLoadByPrimaryKey stored procedure.

    public class GetprocEnterpriseGradeRenewalByPrimaryKey : IRequest<GetprocEnterpriseGradeRenewalLoadAllListVm>
    {
        public System.Guid Ent_Grading_Detail_ID { get; set; }
    }
}
