 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procBatch.procBatchDelete.procBatchDeleteCommand
{

    // @author  Shimels Alem  proc_BatchDelete stored procedure.

    public class procBatchDeleteCommand : IRequest<IList<Batch_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 