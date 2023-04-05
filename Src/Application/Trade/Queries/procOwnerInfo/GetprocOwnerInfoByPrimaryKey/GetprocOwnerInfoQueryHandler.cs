using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Trade.Quiries.procOwnerInfo.GetprocOwnerInfoLoadAll;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procOwnerInfo.GetprocOwnerInfoByPrimaryKey
{
    public class GetprocOwnerInfoQueryHandler : IRequestHandler<GetprocOwnerInfoByPrimaryKey, GetprocOwnerInfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocOwnerInfoQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOwnerInfoLoadAllListVm> Handle(GetprocOwnerInfoByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<OwnerInfo> procOwnerInfos = await _procedureAdabter
               .Execute<OwnerInfo>("[Trade].[proc_Owner_InfoLoadByPrimaryKey]", request);
            GetprocOwnerInfoLoadAllListVm vm = new GetprocOwnerInfoLoadAllListVm
            {
                procOwnerInfos = _mapper.Map<IList<OwnerInfo>, IList<GetprocOwnerInfoLoadAllVm>>(procOwnerInfos)
            };

            return vm;
        }
    }
}
