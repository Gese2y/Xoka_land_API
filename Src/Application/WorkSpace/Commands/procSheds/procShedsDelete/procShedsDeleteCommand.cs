 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Commands.procSheds.procShedsDelete.procShedsDeleteCommand
{

    // @author  Shimels Alem  proc_ShedsDelete stored procedure.

    public class procShedsDeleteCommand : IRequest<IList<Sheds_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 