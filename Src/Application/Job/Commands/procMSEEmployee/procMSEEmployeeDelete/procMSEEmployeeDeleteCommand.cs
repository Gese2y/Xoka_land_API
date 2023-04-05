 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procMSEEmployee.procMSEEmployeeDelete.procMSEEmployeeDeleteCommand
{

    // @author  Shimels Alem  proc_MSE_EmployeeDelete stored procedure.

    public class procMSEEmployeeDeleteCommand : IRequest<IList<MSEEmployee_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 