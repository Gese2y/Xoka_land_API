


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procExamResultCertificat.procExamResultCertificatInsert.procExamResultCertificatInsertCommand
{

	/// @author  Shimels Alem  proc_Exam_Result_CertificatInsert stored procedure.
	public class procExamResultCertificatInsertCommand : IRequest<IList<ExamResultCertificat_ID>>
    {
		public System.Guid ID { get; set; }
		public System.Guid? Exam_Result_Id { get; set; }
		public string TEVET_Program_ID { get; set; }
		public System.DateTime? Date_Issued { get; set; }
		public System.DateTime? Expired_Date { get; set; }
		public bool? Is_Summitted_To_candidate { get; set; }
	}
		
		
		 
}
 
 