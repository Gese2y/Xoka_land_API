

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procSchedule.procScheduleUpdate.procScheduleUpdateCommand
{

    /// @author  Shimels Alem  proc_ScheduleUpdate stored procedure.


    public class procScheduleUpdateHandler : IRequestHandler<procScheduleUpdateCommand, IList<Schedule_SID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procScheduleUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Schedule_SID>> Handle( procScheduleUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Schedule_SID> result = await _procedureAdabter
                .Execute<Schedule_SID>("[TVET].proc_ScheduleUpdate", request);
           

            return result;
        }
    }
}
 