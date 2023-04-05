using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procSchedule.procScheduleDelete.procScheduleDeleteCommand
{

    /// @author  Shimels Alem  proc_ScheduleDelete stored procedure.


    public class procScheduleDeleteHandler : IRequestHandler<procScheduleDeleteCommand, IList<Schedule_SID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procScheduleDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Schedule_SID>> Handle( procScheduleDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Schedule_SID> result = await _procedureAdabter
                .Execute<Schedule_SID>("[Job].proc_ScheduleDelete", request);
           

            return result;
        }
    }
}
  