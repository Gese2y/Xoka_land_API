using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procMarketOPP.GetprocMarketOPPLoadAll
{
    class GetprocMarketOPPLoadAllQueryHandler : IRequestHandler<GetprocMarketOPPLoadAllQuery, GetprocMarketOPPLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocMarketOPPLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocMarketOPPLoadAllListVm> Handle(GetprocMarketOPPLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<MarketOPP> procMarketOPPs = await _procedureAdabter
               .Execute<MarketOPP>("[Job].[proc_Market_OPPLoadAll]");
            GetprocMarketOPPLoadAllListVm vm = new GetprocMarketOPPLoadAllListVm
            {
                procMarketOPPs = _mapper.Map<IList<MarketOPP>, IList<GetprocMarketOPPLoadAllVm>>(procMarketOPPs)
            };

            return vm;
        }
    }
}
