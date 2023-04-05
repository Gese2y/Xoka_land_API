 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procOCACExam.procOCACExamDelete.procOCACExamDeleteCommand
{

    // @author  Shimels Alem  proc_OCAC_ExamDelete stored procedure.

    public class procOCACExamDeleteCommand : IRequest<IList<OCACExam_ExamID>>
    {
        public string Exam_ID { get; set; }
    }
		
     
		
		 
}
 
 