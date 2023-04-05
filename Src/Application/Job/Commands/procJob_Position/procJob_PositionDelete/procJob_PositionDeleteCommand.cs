 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procJob_Position.procJob_PositionDelete.procJob_PositionDeleteCommand
{

    // @author  Shimels Alem  proc_MSE_EmployeeDelete stored procedure.

    public class procJob_PositionDeleteCommand : IRequest<IList<Job_Position_Id>>
    {
        public string Job_Position_ID { get; set; }
    }
		
     
		
		 
}
 
 