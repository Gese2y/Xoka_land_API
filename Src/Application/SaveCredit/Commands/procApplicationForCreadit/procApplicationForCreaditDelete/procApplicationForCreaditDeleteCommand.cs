 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Commands.procApplicationForCreadit.procApplicationForCreaditDelete.procApplicationForCreaditDeleteCommand
{

    // @author  Shimels Alem  proc_Application_For_CreaditDelete stored procedure.

    public class procApplicationForCreaditDeleteCommand : IRequest<IList<ApplicationForCreadit_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 