using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procOCACExamCandidate.GetprocOCACExamCandidateLoadAll;

namespace Application.OCAC.Quiries.procOCACExamCandidate.GetprocOCACExamCandidateByPrimaryKey
{
    /// @author  Shimels Alem proc_OCAC_Exam__CandidateLoadByPrimaryKey stored procedure.

    public class GetprocOCACExamCandidateByPrimaryKey : IRequest<GetprocOCACExamCandidateLoadAllListVm>
    {
        public System.Guid OCAC_Candiate { get; set; }
    }
}
