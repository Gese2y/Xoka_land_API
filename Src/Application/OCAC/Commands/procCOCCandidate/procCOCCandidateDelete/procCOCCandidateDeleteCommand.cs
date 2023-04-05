 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procCOCCandidate.procCOCCandidateDelete.procCOCCandidateDeleteCommand
{

    // @author  Shimels Alem  proc_COC_CandidateDelete stored procedure.

    public class procCOCCandidateDeleteCommand : IRequest<IList<COCCandidate_COCCandID>>
    {
        public System.Guid COC_Cand_ID { get; set; }
    }
		
     
		
		 
}
 
 