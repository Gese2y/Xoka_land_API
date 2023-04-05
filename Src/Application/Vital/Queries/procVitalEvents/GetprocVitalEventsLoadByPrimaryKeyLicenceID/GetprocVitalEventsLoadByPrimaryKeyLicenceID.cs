using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vital.Quiries.procVitalEvents.GetprocVitalEventsLoadAll;

namespace Application.Vital.Quiries.procVitalEvents.GetprocVitalEventsLoadByPrimaryKeyLicenceID
{
    /// @author  Shimels Alem proc_Vital_EventsLoadByPrimaryKey_Licence_ID stored procedure.

    public class GetprocVitalEventsLoadByPrimaryKeyLicenceID : IRequest<GetprocVitalEventsLoadAllListVm>
    {
        public System.Guid Licence_ID { get; set; }
    }
}
