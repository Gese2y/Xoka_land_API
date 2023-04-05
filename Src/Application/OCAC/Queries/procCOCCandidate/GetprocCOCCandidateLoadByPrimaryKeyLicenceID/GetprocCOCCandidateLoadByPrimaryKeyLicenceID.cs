using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procCOCCandidate.GetprocCOCCandidateLoadAll;

namespace Application.OCAC.Quiries.procCOCCandidate.GetprocCOCCandidateLoadByPrimaryKeyLicenceID
{
    /// @author  Shimels Alem proc_COC_CandidateLoadByPrimaryKey_Licence_ID stored procedure.

    public class GetprocCOCCandidateLoadByPrimaryKeyLicenceID : IRequest<GetprocCOCCandidateLoadAllListVm>
    {
        public System.Guid Licence_ID { get; set; }
    }
}
