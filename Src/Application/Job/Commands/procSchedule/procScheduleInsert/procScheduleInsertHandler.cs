﻿



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procSchedule.procScheduleInsert.procScheduleInsertCommand
{

    /// @author  Shimels Alem  proc_ScheduleInsert stored procedure.


    public class procScheduleInsertHandler : IRequestHandler<procScheduleInsertCommand, IList<Schedule_SID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procScheduleInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Schedule_SID>> Handle( procScheduleInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Schedule_SID> result = await _procedureAdabter
                .Execute<Schedule_SID>("[Job].proc_ScheduleInsert", request);
           

            return result;
        }
    }
}
 