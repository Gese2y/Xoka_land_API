 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procOCACExamCandidate.procOCACExamCandidateDelete.procOCACExamCandidateDeleteCommand
{

    // @author  Shimels Alem  proc_OCAC_Exam__CandidateDelete stored procedure.

    public class procOCACExamCandidateDeleteCommand : IRequest<IList<OCACExamCandidate_OCACCandiate>>
    {
        public System.Guid OCAC_Candiate { get; set; }
    }
		
     
		
		 
}
 
 