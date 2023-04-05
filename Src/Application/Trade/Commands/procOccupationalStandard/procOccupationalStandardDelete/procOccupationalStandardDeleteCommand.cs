 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procOccupationalStandard.procOccupationalStandardDelete.procOccupationalStandardDeleteCommand
{

    // @author  Shimels Alem  proc_Occupational_StandardDelete stored procedure.

    public class procOccupationalStandardDeleteCommand : IRequest<IList<OccupationalStandard_OSID>>
    {
        public string OS_ID { get; set; }
    }
		
     
		
		 
}
 
 