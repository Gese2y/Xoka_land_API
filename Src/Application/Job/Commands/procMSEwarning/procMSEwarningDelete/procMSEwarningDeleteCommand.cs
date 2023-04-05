 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procMSEwarning.procMSEwarningDelete.procMSEwarningDeleteCommand
{

    // @author  Shimels Alem  proc_MSE_EmployeeDelete stored procedure.

    public class procMSEwarningDeleteCommand : IRequest<IList<MSEwarning_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 