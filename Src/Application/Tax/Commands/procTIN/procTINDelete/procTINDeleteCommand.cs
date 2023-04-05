 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Commands.procTIN.procTINDelete.procTINDeleteCommand
{

    // @author  Shimels Alem  proc_TINDelete stored procedure.

    public class procTINDeleteCommand : IRequest<IList<TIN_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 