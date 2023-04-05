 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procEducation.procEducationDelete.procEducationDeleteCommand
{

    // @author  Shimels Alem  proc_EducationDelete stored procedure.

    public class procEducationDeleteCommand : IRequest<IList<Education_ID>>
    {

        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 