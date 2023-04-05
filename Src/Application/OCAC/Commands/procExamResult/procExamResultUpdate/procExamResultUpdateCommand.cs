using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procExamResult.procExamResultUpdate.procExamResultUpdateCommand
{

	/// @author  Shimels Alem  proc_Exam_ResultUpdate stored procedure.

	public class procExamResultUpdateCommand : IRequest<IList<ExamResult_ID>>
   {
		public System.Guid ID { get; set; }
		public System.Guid? OCAC_Exam_Cad_ID { get; set; }
		public double? Result_In_Number { get; set; }
		public string Result_In_Text { get; set; }
		public System.DateTime? Date_of_Exam { get; set; }
	}
		
		
		 
}

