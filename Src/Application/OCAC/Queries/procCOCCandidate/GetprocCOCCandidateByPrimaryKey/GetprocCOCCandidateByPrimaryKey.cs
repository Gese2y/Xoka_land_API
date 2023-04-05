using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procCOCCandidate.GetprocCOCCandidateLoadAll;

namespace Application.OCAC.Quiries.procCOCCandidate.GetprocCOCCandidateByPrimaryKey
{
    /// @author  Shimels Alem proc_COC_CandidateLoadByPrimaryKey stored procedure.

    public class GetprocCOCCandidateByPrimaryKey : IRequest<GetprocCOCCandidateLoadAllListVm>
    {
        public System.Guid COC_Cand_ID { get; set; }
    }
}
