using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procSchedule.GetprocScheduleLoadAll
{
    class GetprocScheduleLoadAllQueryHandler : IRequestHandler<GetprocScheduleLoadAllQuery, GetprocScheduleLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocScheduleLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocScheduleLoadAllListVm> Handle(GetprocScheduleLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Schedule> procSchedules = await _procedureAdabter
               .Execute<Schedule>("[TVET].[proc_ScheduleLoadAll]");
            GetprocScheduleLoadAllListVm vm = new GetprocScheduleLoadAllListVm
            {
                procSchedules = _mapper.Map<IList<Schedule>, IList<GetprocScheduleLoadAllVm>>(procSchedules)
            };

            return vm;
        }
    }
}
