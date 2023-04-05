 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procStakeholder.procStakeholderDelete.procStakeholderDeleteCommand
{

    // @author  Shimels Alem  proc_MSE_EmployeeDelete stored procedure.

    public class procStakeholderDeleteCommand : IRequest<IList<Stakeholder_ID>>
    {
        public string Stakeholder_TIN { get; set; }

    }
		
     
		
		 
}
 
 