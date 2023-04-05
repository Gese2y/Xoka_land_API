using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Quiries.procCollateral.GetprocCollateralLoadAll
{
    class GetprocCollateralLoadAllQueryHandler : IRequestHandler<GetprocCollateralLoadAllQuery, GetprocCollateralLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCollateralLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCollateralLoadAllListVm> Handle(GetprocCollateralLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Collateral> procCollaterals = await _procedureAdabter
               .Execute<Collateral>("[SaveCredit].[proc_CollateralLoadAll]");
            GetprocCollateralLoadAllListVm vm = new GetprocCollateralLoadAllListVm
            {
                procCollaterals = _mapper.Map<IList<Collateral>, IList<GetprocCollateralLoadAllVm>>(procCollaterals)
            };

            return vm;
        }
    }
}
