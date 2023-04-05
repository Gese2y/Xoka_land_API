 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procTVETResult.procTVETResultDelete.procTVETResultDeleteCommand
{

    // @author  Shimels Alem  proc_TVET_ResultDelete stored procedure.

    public class procTVETResultDeleteCommand : IRequest<IList<TVETResult_RId>>
    {
        public System.Guid RId { get; set; }
    }
		
     
		
		 
}
 
 