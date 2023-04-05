 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procExamResult.procExamResultDelete.procExamResultDeleteCommand
{

    // @author  Shimels Alem  proc_Exam_ResultDelete stored procedure.

    public class procExamResultDeleteCommand : IRequest<IList<ExamResult_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 