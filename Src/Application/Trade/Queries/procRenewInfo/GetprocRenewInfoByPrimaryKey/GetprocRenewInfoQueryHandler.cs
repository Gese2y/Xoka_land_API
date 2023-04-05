using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Trade.Quiries.procRenewInfo.GetprocRenewInfoLoadAll;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procRenewInfo.GetprocRenewInfoByPrimaryKey
{
    public class GetprocRenewInfoQueryHandler : IRequestHandler<GetprocRenewInfoByPrimaryKey, GetprocRenewInfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocRenewInfoQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocRenewInfoLoadAllListVm> Handle(GetprocRenewInfoByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<RenewInfo> procRenewInfos = await _procedureAdabter
               .Execute<RenewInfo>("[Trade].[proc_Renew_InfoLoadByPrimaryKey]", request);
            GetprocRenewInfoLoadAllListVm vm = new GetprocRenewInfoLoadAllListVm
            {
                procRenewInfos = _mapper.Map<IList<RenewInfo>, IList<GetprocRenewInfoLoadAllVm>>(procRenewInfos)
            };

            return vm;
        }
    }
}
