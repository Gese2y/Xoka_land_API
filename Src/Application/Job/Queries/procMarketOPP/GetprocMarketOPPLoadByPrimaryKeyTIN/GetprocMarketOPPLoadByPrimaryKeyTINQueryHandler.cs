using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procMarketOPP.GetprocMarketOPPLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procMarketOPP.GetprocMarketOPPLoadByPrimaryKeyTIN
{
    public class GetprocMarketOPPQueryHandler : IRequestHandler<GetprocMarketOPPLoadByPrimaryKeyTIN, GetprocMarketOPPLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocMarketOPPQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocMarketOPPLoadAllListVm> Handle(GetprocMarketOPPLoadByPrimaryKeyTIN request, CancellationToken cancellationToken)
        {
           
            IList<MarketOPP> procMarketOPPs = await _procedureAdabter
               .Execute<MarketOPP>("[Job].[proc_Market_OPPLoadByPrimaryKey_TIN]", request);
            GetprocMarketOPPLoadAllListVm vm = new GetprocMarketOPPLoadAllListVm
            {
                procMarketOPPs = _mapper.Map<IList<MarketOPP>, IList<GetprocMarketOPPLoadAllVm>>(procMarketOPPs)
            };

            return vm;
        }
    }
}
