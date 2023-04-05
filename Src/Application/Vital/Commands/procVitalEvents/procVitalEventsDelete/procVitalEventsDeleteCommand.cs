 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Vital;

namespace Application.Vital.Commands.procVitalEvents.procVitalEventsDelete.procVitalEventsDeleteCommand
{

    // @author  Shimels Alem  proc_Vital_EventsDelete stored procedure.

    public class procVitalEventsDeleteCommand : IRequest<IList<VitalEvents_ID>>
    {
		public string ID { get; set; }
	}
		
    
}
 
 