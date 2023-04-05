 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procCoCApplayExamFor.procCoCApplayExamForDelete.procCoCApplayExamForDeleteCommand
{

    // @author  Shimels Alem  proc_CoCApplay_Exam_ForDelete stored procedure.

    public class procCoCApplayExamForDeleteCommand : IRequest<IList<CoCApplayExamFor_Id>>
    {
        public System.Guid Id { get; set; }
    }
		
     
		
		 
}
 
 