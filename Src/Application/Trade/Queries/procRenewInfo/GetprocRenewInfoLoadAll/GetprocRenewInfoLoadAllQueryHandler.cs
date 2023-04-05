using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procRenewInfo.GetprocRenewInfoLoadAll
{
    class GetprocRenewInfoLoadAllQueryHandler : IRequestHandler<GetprocRenewInfoLoadAllQuery, GetprocRenewInfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocRenewInfoLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocRenewInfoLoadAllListVm> Handle(GetprocRenewInfoLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<RenewInfo> procRenewInfos = await _procedureAdabter
               .Execute<RenewInfo>("[Trade].[proc_Renew_InfoLoadAll]");
            GetprocRenewInfoLoadAllListVm vm = new GetprocRenewInfoLoadAllListVm
            {
                procRenewInfos = _mapper.Map<IList<RenewInfo>, IList<GetprocRenewInfoLoadAllVm>>(procRenewInfos)
            };

            return vm;
        }
    }
}
