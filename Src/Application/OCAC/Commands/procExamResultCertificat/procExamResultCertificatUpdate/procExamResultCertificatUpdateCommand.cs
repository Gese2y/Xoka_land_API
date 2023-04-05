using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procExamResultCertificat.procExamResultCertificatUpdate.procExamResultCertificatUpdateCommand
{

	/// @author  Shimels Alem  proc_Exam_Result_CertificatUpdate stored procedure.

	public class procExamResultCertificatUpdateCommand : IRequest<IList<ExamResultCertificat_ID>>
   {
		public System.Guid ID { get; set; }
		public System.Guid? Exam_Result_Id { get; set; }
		public string TEVET_Program_ID { get; set; }
		public System.DateTime? Date_Issued { get; set; }
		public System.DateTime? Expired_Date { get; set; }
		public bool? Is_Summitted_To_candidate { get; set; }
	}
		
		
		 
}

