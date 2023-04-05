using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.SaveCredit.Quiries.procCollateral.GetprocCollateralLoadAll;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Quiries.procCollateral.GetprocCollateralByPrimaryKey
{
    public class GetprocCollateralQueryHandler : IRequestHandler<GetprocCollateralByPrimaryKey, GetprocCollateralLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCollateralQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCollateralLoadAllListVm> Handle(GetprocCollateralByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Collateral> procCollaterals = await _procedureAdabter
               .Execute<Collateral>("[SaveCredit].[proc_CollateralLoadByPrimaryKey]", request);
            GetprocCollateralLoadAllListVm vm = new GetprocCollateralLoadAllListVm
            {
                procCollaterals = _mapper.Map<IList<Collateral>, IList<GetprocCollateralLoadAllVm>>(procCollaterals)
            };

            return vm;
        }
    }
}
