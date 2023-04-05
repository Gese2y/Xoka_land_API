using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procStandardExamReq.procStandardExamReqUpdate.procStandardExamReqUpdateCommand
{ 
	 
	/// @author  Shimels Alem  [sp not found] stored procedure.
	 
    public class procStandardExamReqUpdateCommand : IRequest<IList<StandardExamReq_OSIDAndOCACExam>>
   {
		public string OS_ID { get; set; }
		public string OCAC_Exam { get; set; }
		public bool? Is_Active { get; set; }
	}
		
		
		 
}

