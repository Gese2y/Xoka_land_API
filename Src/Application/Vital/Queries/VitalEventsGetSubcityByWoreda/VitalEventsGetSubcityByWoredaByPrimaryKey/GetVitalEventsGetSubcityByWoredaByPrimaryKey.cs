using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vital.Quiries.VitalEventsGetSubcityByWoreda.VitalEventsGetSubcityByWoredaLoadAll;

namespace Application.Vital.Quiries.VitalEventsGetSubcityByWoreda.GetVitalEventsGetSubcityByWoredaByPrimaryKey
{
    /// @author  Shimels Alem proc_Vital_EventsLoadByPrimaryKey stored procedure.

    public class GetVitalEventsGetSubcityByWoredaByPrimaryKey : IRequest<GetVitalEventsGetSubcityByWoredaOrgLoadListVm>
    {
        public string ID { get; set; }
    }
}
