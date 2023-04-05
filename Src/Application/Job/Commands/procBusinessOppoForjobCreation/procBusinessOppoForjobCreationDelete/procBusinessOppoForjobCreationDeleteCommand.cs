 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procBusinessOppoForjobCreation.procBusinessOppoForjobCreationDelete.procBusinessOppoForjobCreationDeleteCommand
{

    // @author  Shimels Alem  proc_Business_Oppo_For__job_CreationDelete stored procedure.

    public class procBusinessOppoForjobCreationDeleteCommand : IRequest<IList<BusinessOppoForjobCreation_BUSOPPID>>
    {
        public System.Guid BUS_OPP_ID { get; set; }
    }
		
     
		
		 
}
 
 