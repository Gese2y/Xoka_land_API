using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procOCACExam.procOCACExamUpdate.procOCACExamUpdateCommand
{

    /// @author  Shimels Alem  proc_OCAC_ExamUpdate stored procedure.

    public class procOCACExamUpdateCommand : IRequest<IList<OCACExam_ExamID>>
   {
        public string Exam_ID { get; set; }
        public string Name { get; set; }
        public string Exam_Type { get; set; }
        public string Pass_Mark { get; set; }
        public bool? Active { get; set; }
    }
		
		
		 
}

