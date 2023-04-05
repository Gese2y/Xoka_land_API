 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procJob_Opportunity.procJob_OpportunityDelete.procJob_OpportunityDeleteCommand
{

    // @author  Shimels Alem  proc_MSE_EmployeeDelete stored procedure.

    public class procJob_OpportunityDeleteCommand : IRequest<IList<Job_Opportunity_Id>>
    {
        public System.Guid Job_Opportunity_ID { get; set; }

    }
		
     
		
		 
}
 
 