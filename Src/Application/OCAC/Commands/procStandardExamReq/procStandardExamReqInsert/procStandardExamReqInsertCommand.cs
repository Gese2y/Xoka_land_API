


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procStandardExamReq.procStandardExamReqInsert.procStandardExamReqInsertCommand
{

    /// @author  Shimels Alem  proc_Standard_Exam_ReqInsert stored procedure.


    public class procStandardExamReqInsertCommand : IRequest<IList<StandardExamReq_OSIDAndOCACExam>>
    {
        public string OS_ID { get; set; }
        public string OCAC_Exam { get; set; }
        public bool? Is_Active { get; set; }
    }
		
		
		 
}
 
 