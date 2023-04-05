


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Vital;

namespace Application.Vital.Commands.procVitalEvents.procVitalEventsInsert.procVitalEventsInsertCommand
{

    /// @author  Shimels Alem  proc_Vital_EventsInsert stored procedure.


    public class procVitalEventsInsertCommand : IRequest<IList<VitalEvents_ID>>
    {
		public string ID { get; set; }
		public System.DateTime? Date_of_Birth { get; set; }
		public string Blood_Group { get; set; }
		public string Gender { get; set; }
		public string Status { get; set; }
		public System.Guid? Regstered_Org { get; set; }
		public System.Guid? User_ID { get; set; }
		public System.DateTime? created_date { get; set; }
		public System.DateTime? Updated_date { get; set; }
		public System.Guid? Updated_By_user { get; set; }
		public System.Guid? Licence_ID { get; set; }
	}
		
		
		 
}
 
 