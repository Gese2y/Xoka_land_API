using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procOwnerInfo.GetprocOwnerInfoLoadAll
{
    class GetprocOwnerInfoLoadAllQueryHandler : IRequestHandler<GetprocOwnerInfoLoadAllQuery, GetprocOwnerInfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocOwnerInfoLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOwnerInfoLoadAllListVm> Handle(GetprocOwnerInfoLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<OwnerInfo> procOwnerInfos = await _procedureAdabter
               .Execute<OwnerInfo>("[Trade].[proc_Owner_InfoLoadAll]");
            GetprocOwnerInfoLoadAllListVm vm = new GetprocOwnerInfoLoadAllListVm
            {
                procOwnerInfos = _mapper.Map<IList<OwnerInfo>, IList<GetprocOwnerInfoLoadAllVm>>(procOwnerInfos)
            };

            return vm;
        }
    }
}
