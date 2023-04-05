

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vital;
using XOKA.Domain.Interfaces;

namespace Application.Vital.Commands.procVitalEvents.procVitalEventsUpdate.procVitalEventsUpdateCommand
{

    /// @author  Shimels Alem  proc_Vital_EventsUpdate stored procedure.


    public class procVitalEventsUpdateHandler : IRequestHandler<procVitalEventsUpdateCommand, IList<VitalEvents_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procVitalEventsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VitalEvents_ID>> Handle( procVitalEventsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<VitalEvents_ID> result = await _procedureAdabter
                .Execute<VitalEvents_ID>("[Vital].proc_Vital_EventsUpdate", request);
           

            return result;
        }
    }
}
 