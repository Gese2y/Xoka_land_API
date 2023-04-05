using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procJob_Match.GetprocJob_MatchLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procJob_Match.GetprocJob_MatchByTransactionID
{
    public class GetprocJob_MatchQueryHandler : IRequestHandler<GetprocJob_MatchByTransactionID, GetprocJob_MatchLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJob_MatchQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJob_MatchLoadAllListVm> Handle(GetprocJob_MatchByTransactionID request, CancellationToken cancellationToken)
        {
           
            IList<Job_Match> procJob_Matchs = await _procedureAdabter
               .Execute<Job_Match>("[Job].[proc_Job_MatchLoadByTransactionID]", request);
            GetprocJob_MatchLoadAllListVm vm = new GetprocJob_MatchLoadAllListVm
            {
                procJob_Matchs = _mapper.Map<IList<Job_Match>, IList<GetprocJob_MatchLoadAllVm>>(procJob_Matchs)
            };

            return vm;
        }
    }
}
