 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procSub_City_Job_Assignment_Transaction.procSub_City_Job_Assignment_TransactionDelete.procSub_City_Job_Assignment_TransactionDeleteCommand
{

    // @author  Shimels Alem  proc_MSE_EmployeeDelete stored procedure.

    public class procSub_City_Job_Assignment_TransactionDeleteCommand : IRequest<IList<Sub_City_Job_Assignment_Transaction_ID>>
    {
        public System.Guid Transaction_ID { get; set; }
        
    }
		
     
		
		 
}
 
 