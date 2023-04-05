


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procOccupationalStandard.procOccupationalStandardInsert.procOccupationalStandardInsertCommand
{

    /// @author  Shimels Alem  proc_Occupational_StandardInsert stored procedure.


    public class procOccupationalStandardInsertCommand : IRequest<IList<OccupationalStandard_OSID>>
    {
        public string OS_ID { get; set; }
        public string Name { get; set; }
        public System.Guid? Parent { get; set; }
        public string Version { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public bool? IS_Active { get; set; }
    }
		
		
		 
}
 
 