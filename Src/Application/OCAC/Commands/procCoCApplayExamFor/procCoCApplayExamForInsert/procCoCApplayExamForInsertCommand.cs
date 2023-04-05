


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procCoCApplayExamFor.procCoCApplayExamForInsert.procCoCApplayExamForInsertCommand
{

	/// @author  Shimels Alem  proc_CoCApplay_Exam_ForInsert stored procedure.


	public class procCoCApplayExamForInsertCommand : IRequest<IList<CoCApplayExamFor_Id>>
    {
		public System.Guid Id { get; set; }
		public System.Guid? COC_Cand_ID { get; set; }
		public string OS_ID { get; set; }
		public string Exam_ID { get; set; }
	}
		
		
		 
}
 
 