 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procJob_Match.procJob_MatchDelete.procJob_MatchDeleteCommand
{

    // @author  Shimels Alem  proc_MSE_EmployeeDelete stored procedure.

    public class procJob_MatchDeleteCommand : IRequest<IList<Job_Match_Id>>
    {
        public System.Guid Job_Match_ID { get; set; }
       
    }
		
     
		
		 
}
 
 