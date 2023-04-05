 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procMKTProdIO.procMKTProdIODelete.procMKTProdIODeleteCommand
{

    // @author  Shimels Alem  proc_MKT_Prod_IODelete stored procedure.

    public class procMKTProdIODeleteCommand : IRequest<IList<MKTProdIO_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 