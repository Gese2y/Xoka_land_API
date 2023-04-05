 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.DAR;

namespace Application.DAR.Commands.procDAR.procDARDelete.procDARDeleteCommand
{

    // @author  Shimels Alem  proc_DARDelete stored procedure.

    public class procDARDeleteCommand : IRequest<IList<DAR_DARNO>>
    {
        public string DAR_NO { get; set; }
    }
		
     
		
		 
}
 
 