 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Commands.procWorkSpace.procWorkSpaceDelete.procWorkSpaceDeleteCommand
{

    // @author  Shimels Alem  proc_Work_SpaceDelete stored procedure.

    public class procWorkSpaceDeleteCommand : IRequest<IList<WorkSpace_WorkSpaceID>>
    {
        public System.Guid Work_Space_ID { get; set; }
    }
		
     
		
		 
}
 
 