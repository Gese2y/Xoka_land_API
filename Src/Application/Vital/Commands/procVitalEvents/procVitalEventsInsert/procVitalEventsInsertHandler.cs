



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vital;
using XOKA.Domain.Interfaces;


namespace Application.Vital.Commands.procVitalEvents.procVitalEventsInsert.procVitalEventsInsertCommand
{

    /// @author  Shimels Alem  proc_Vital_EventsInsert stored procedure.


    public class procVitalEventsInsertHandler : IRequestHandler<procVitalEventsInsertCommand, IList<VitalEvents_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procVitalEventsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VitalEvents_ID>> Handle( procVitalEventsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<VitalEvents_ID> result = await _procedureAdabter
                .Execute<VitalEvents_ID>("[Vital].proc_Vital_EventsInsert", request);
           

            return result;
        }
    }
}
 