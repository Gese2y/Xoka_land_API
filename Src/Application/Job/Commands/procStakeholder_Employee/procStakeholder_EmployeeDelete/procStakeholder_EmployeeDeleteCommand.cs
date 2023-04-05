 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procStakeholder_Employee.procStakeholder_EmployeeDelete.procStakeholder_EmployeeDeleteCommand
{

    // @author  Shimels Alem  proc_MSE_EmployeeDelete stored procedure.

    public class procStakeholder_EmployeeDeleteCommand : IRequest<IList<Stakeholder_Employee_Id>>
    {
        public System.Guid Stakeholder_Employee_ID { get; set; }
       
    }
		
     
		
		 
}
 
 