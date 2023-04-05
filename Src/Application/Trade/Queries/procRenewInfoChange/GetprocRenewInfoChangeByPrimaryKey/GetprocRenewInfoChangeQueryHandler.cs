using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Trade.Quiries.procRenewInfoChange.GetprocRenewInfoChangeLoadAll;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procRenewInfoChange.GetprocRenewInfoChangeByPrimaryKey
{
    public class GetprocRenewInfoChangeQueryHandler : IRequestHandler<GetprocRenewInfoChangeByPrimaryKey, GetprocRenewInfoChangeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocRenewInfoChangeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocRenewInfoChangeLoadAllListVm> Handle(GetprocRenewInfoChangeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<RenewInfoChange> procRenewInfoChanges = await _procedureAdabter
               .Execute<RenewInfoChange>("[Trade].[proc_Renew_Info_ChangeLoadByPrimaryKey]", request);
            GetprocRenewInfoChangeLoadAllListVm vm = new GetprocRenewInfoChangeLoadAllListVm
            {
                procRenewInfoChanges = _mapper.Map<IList<RenewInfoChange>, IList<GetprocRenewInfoChangeLoadAllVm>>(procRenewInfoChanges)
            };

            return vm;
        }
    }
}
