 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procBranch.procBranchDelete.procBranchDeleteCommand
{

    // @author  Shimels Alem  proc_BranchDelete stored procedure.

    public class procBranchDeleteCommand : IRequest<IList<Branch_ID>>
    {

        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 