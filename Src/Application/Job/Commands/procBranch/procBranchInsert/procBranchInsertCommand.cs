


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procBranch.procBranchInsert.procBranchInsertCommand
{

    /// @author  Shimels Alem  proc_BranchInsert stored procedure.


    public class procBranchInsertCommand : IRequest<IList<Branch_ID>>
    {
        public System.Guid ID { get; set; }
        public byte[]? Address { get; set; }
        public string Type { get; set; }
        public string Product { get; set; }
    }
		
		
		 
}
 
 