 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procBazarAndExhibition.procBazarAndExhibitionDelete.procBazarAndExhibitionDeleteCommand
{

    // @author  Shimels Alem  proc_Bazar&ExhibitionDelete stored procedure.

    public class procBazarAndExhibitionDeleteCommand : IRequest<IList<BazarAndExhibition_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 