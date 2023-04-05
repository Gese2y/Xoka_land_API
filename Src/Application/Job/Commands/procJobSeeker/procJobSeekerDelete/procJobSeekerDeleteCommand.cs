 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procJobSeeker.procJobSeekerDelete.procJobSeekerDeleteCommand
{

    // @author  Shimels Alem  proc_Job_SeekerDelete stored procedure.

    public class procJobSeekerDeleteCommand : IRequest<IList<JobSeeker_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 