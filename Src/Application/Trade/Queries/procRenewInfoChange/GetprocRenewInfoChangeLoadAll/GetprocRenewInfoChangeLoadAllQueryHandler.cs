using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procRenewInfoChange.GetprocRenewInfoChangeLoadAll
{
    class GetprocRenewInfoChangeLoadAllQueryHandler : IRequestHandler<GetprocRenewInfoChangeLoadAllQuery, GetprocRenewInfoChangeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocRenewInfoChangeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocRenewInfoChangeLoadAllListVm> Handle(GetprocRenewInfoChangeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<RenewInfoChange> procRenewInfoChanges = await _procedureAdabter
               .Execute<RenewInfoChange>("[Trade].[proc_Renew_Info_ChangeLoadAll]");
            GetprocRenewInfoChangeLoadAllListVm vm = new GetprocRenewInfoChangeLoadAllListVm
            {
                procRenewInfoChanges = _mapper.Map<IList<RenewInfoChange>, IList<GetprocRenewInfoChangeLoadAllVm>>(procRenewInfoChanges)
            };

            return vm;
        }
    }
}
