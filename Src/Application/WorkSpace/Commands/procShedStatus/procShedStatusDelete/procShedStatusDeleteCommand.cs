 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Commands.procShedStatus.procShedStatusDelete.procShedStatusDeleteCommand
{

    // @author  Shimels Alem  proc_Shed_StatusDelete stored procedure.

    public class procShedStatusDeleteCommand : IRequest<IList<ShedStatus_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 