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

namespace Application.Trade.Quiries.procRenewInfoChange.GetprocRenewInfoChangeLoadByPrimaryKeyID
{
    public class GetprocRenewInfoChangeQueryHandler : IRequestHandler<GetprocRenewInfoChangeLoadByPrimaryKeyID, GetprocRenewInfoChangeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocRenewInfoChangeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocRenewInfoChangeLoadAllListVm> Handle(GetprocRenewInfoChangeLoadByPrimaryKeyID request, CancellationToken cancellationToken)
        {
           
            IList<RenewInfoChange> procRenewInfoChanges = await _procedureAdabter
               .Execute<RenewInfoChange>("[Trade].[proc_Renew_Info_ChangeLoadByPrimaryKey_ID]", request);
            GetprocRenewInfoChangeLoadAllListVm vm = new GetprocRenewInfoChangeLoadAllListVm
            {
                procRenewInfoChanges = _mapper.Map<IList<RenewInfoChange>, IList<GetprocRenewInfoChangeLoadAllVm>>(procRenewInfoChanges)
            };

            return vm;
        }
    }
}
