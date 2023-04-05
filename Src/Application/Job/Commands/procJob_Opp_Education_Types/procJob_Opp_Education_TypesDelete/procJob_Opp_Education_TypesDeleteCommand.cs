 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procJob_Opp_Education_Types.procJob_Opp_Education_TypesDelete.procJob_Opp_Education_TypesDeleteCommand
{

    // @author  Shimels Alem  proc_MSE_EmployeeDelete stored procedure.

    public class procJob_Opp_Education_TypesDeleteCommand : IRequest<IList<Job_Opp_Education_Types_Id>>
    {
        public System.Guid Job_Opportunity_ID { get; set; }
       

    }
		
     
		
		 
}
 
 