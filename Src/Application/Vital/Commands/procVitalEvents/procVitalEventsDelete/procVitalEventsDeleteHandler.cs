using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vital;
using XOKA.Domain.Interfaces;

namespace Application.Vital.Commands.procVitalEvents.procVitalEventsDelete.procVitalEventsDeleteCommand
{

    /// @author  Shimels Alem  proc_Vital_EventsDelete stored procedure.


    public class procVitalEventsDeleteHandler : IRequestHandler<procVitalEventsDeleteCommand, IList<VitalEvents_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procVitalEventsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VitalEvents_ID>> Handle( procVitalEventsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<VitalEvents_ID> result = await _procedureAdabter
                .Execute<VitalEvents_ID>("[Vital].proc_Vital_EventsDelete", request);
           

            return result;
        }
    }
}
  