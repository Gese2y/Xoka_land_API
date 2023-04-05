 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procExamResultCertificat.procExamResultCertificatDelete.procExamResultCertificatDeleteCommand
{

    // @author  Shimels Alem  proc_Exam_Result_CertificatDelete stored procedure.

    public class procExamResultCertificatDeleteCommand : IRequest<IList<ExamResultCertificat_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 