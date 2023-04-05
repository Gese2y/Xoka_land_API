 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procExamCentor.procExamCentorDelete.procExamCentorDeleteCommand
{

    // @author  Shimels Alem  proc_Exam_CentorDelete stored procedure.

    public class procExamCentorDeleteCommand : IRequest<IList<ExamCentor_CentorCode>>
    {

        public string Centor_Code { get; set; }
    }
		
     
		
		 
}
 
 