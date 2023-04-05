using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procJob_Match.GetprocJob_MatchLoadAll
{
    class GetprocJob_MatchLoadAllQueryHandler : IRequestHandler<GetprocJob_MatchLoadAllQuery, GetprocJob_MatchLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJob_MatchLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJob_MatchLoadAllListVm> Handle(GetprocJob_MatchLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Job_Match> procJob_Matchs = await _procedureAdabter
               .Execute<Job_Match>("[Job].[proc_Job_MatchLoadAll]");
            GetprocJob_MatchLoadAllListVm vm = new GetprocJob_MatchLoadAllListVm
            {
                procJob_Matchs = _mapper.Map<IList<Job_Match>, IList<GetprocJob_MatchLoadAllVm>>(procJob_Matchs)
            };

            return vm;
        }
    }
}
