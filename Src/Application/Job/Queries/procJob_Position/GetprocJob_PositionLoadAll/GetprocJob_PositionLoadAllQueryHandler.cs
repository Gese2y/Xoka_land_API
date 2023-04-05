using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procJob_Position.GetprocJob_PositionLoadAll
{
    class GetprocJob_PositionLoadAllQueryHandler : IRequestHandler<GetprocJob_PositionLoadAllQuery, GetprocJob_PositionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJob_PositionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJob_PositionLoadAllListVm> Handle(GetprocJob_PositionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Job_Position> procJob_Positions = await _procedureAdabter
               .Execute<Job_Position>("[Job].[proc_Job_PositionLoadAll]");
            GetprocJob_PositionLoadAllListVm vm = new GetprocJob_PositionLoadAllListVm
            {
                procJob_Positions = _mapper.Map<IList<Job_Position>, IList<GetprocJob_PositionLoadAllVm>>(procJob_Positions)
            };

            return vm;
        }
    }
}
