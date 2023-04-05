 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procStandardExamReq.procStandardExamReqDelete.procStandardExamReqDeleteCommand
{

    // @author  Shimels Alem  proc_Standard_Exam_ReqDelete stored procedure.

    public class procStandardExamReqDeleteCommand : IRequest<IList<StandardExamReq_OSIDAndOCACExam>>
    {
        public string OS_ID { get; set; }
        public string OCAC_Exam { get; set; }
    }
		
     
		
		 
}
 
 