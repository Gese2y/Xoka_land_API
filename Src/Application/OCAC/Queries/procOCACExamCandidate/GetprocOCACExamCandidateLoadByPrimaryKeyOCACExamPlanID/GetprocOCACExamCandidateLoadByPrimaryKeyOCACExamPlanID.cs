using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procOCACExamCandidate.GetprocOCACExamCandidateLoadAll;

namespace Application.OCAC.Quiries.procOCACExamCandidate.GetprocOCACExamCandidateLoadByPrimaryKeyOCACExamPlanID
{
    /// @author  Shimels Alem proc_OCAC_Exam__CandidateLoadByPrimaryKey_OCAC_Exam_Plan_ID stored procedure.

    public class GetprocOCACExamCandidateLoadByPrimaryKeyOCACExamPlanID : IRequest<GetprocOCACExamCandidateLoadAllListVm>
    {
        public System.Guid OCAC_Exam_Plan_ID { get; set; }
    }
}
