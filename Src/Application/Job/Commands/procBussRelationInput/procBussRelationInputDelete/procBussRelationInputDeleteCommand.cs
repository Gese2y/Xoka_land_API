 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procBussRelationInput.procBussRelationInputDelete.procBussRelationInputDeleteCommand
{

    // @author  Shimels Alem  proc_Buss_Relation_InputDelete stored procedure.

    public class procBussRelationInputDeleteCommand : IRequest<IList<BussRelationInput_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 