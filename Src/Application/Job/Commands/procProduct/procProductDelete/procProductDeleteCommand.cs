 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procProduct.procProductDelete.procProductDeleteCommand
{

    // @author  Shimels Alem  proc_ProductDelete stored procedure.

    public class procProductDeleteCommand : IRequest<IList<Product_ID>>
    {

        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 