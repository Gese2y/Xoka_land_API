 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.UnEmployment.Commands.procEmploymentExperience.procEmploymentExperienceDelete.procEmploymentExperienceDeleteCommand
{

    // @author  Shimels Alem  proc_Employment_ExperienceDelete stored procedure.

    public class procEmploymentExperienceDeleteCommand : IRequest<IList<EmploymentExperience_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 