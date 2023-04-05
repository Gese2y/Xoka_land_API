using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vital.Quiries.procVitalEvents.GetprocVitalEventsLoadAll;

namespace Application.Vital.Quiries.procVitalEvents.GetprocVitalEventsByPrimaryKey
{
    /// @author  Shimels Alem proc_Vital_EventsLoadByPrimaryKey stored procedure.

    public class GetprocVitalEventsByPrimaryKey : IRequest<GetprocVitalEventsLoadAllListVm>
    {
        public string ID { get; set; }
    }
}
