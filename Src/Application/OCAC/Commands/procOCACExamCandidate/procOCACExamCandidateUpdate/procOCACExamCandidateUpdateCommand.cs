using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procOCACExamCandidate.procOCACExamCandidateUpdate.procOCACExamCandidateUpdateCommand
{

    /// @author  Shimels Alem  proc_OCAC_Exam__CandidateUpdate stored procedure.

    public class procOCACExamCandidateUpdateCommand : IRequest<IList<OCACExamCandidate_OCACCandiate>>
   {
        public System.Guid OCAC_Candiate { get; set; }
        public System.Guid? OCAC_Exam_Plan_ID { get; set; }
        public System.Guid? Cand_ID { get; set; }
        public byte[]? IS_Approved { get; set; }
        public string IS_Present { get; set; }
        public string Remark { get; set; }
        public string Student { get; set; }
    }
		
		
		 
}

