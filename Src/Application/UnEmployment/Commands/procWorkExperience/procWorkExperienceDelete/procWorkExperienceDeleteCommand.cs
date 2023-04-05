 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.UnEmployment;

namespace Application.UnEmployment.Commands.procWorkExperience.procWorkExperienceDelete.procWorkExperienceDeleteCommand
{

    // @author  Shimels Alem  proc_Work_ExperienceDelete stored procedure.

    public class procWorkExperienceDeleteCommand : IRequest<IList<WorkExperience_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 