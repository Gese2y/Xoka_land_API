using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procAssets.GetprocAssetsLoadAll
{
    class GetprocAssetsLoadAllQueryHandler : IRequestHandler<GetprocAssetsLoadAllQuery, GetprocAssetsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocAssetsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAssetsLoadAllListVm> Handle(GetprocAssetsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Assets> procAssetss = await _procedureAdabter
               .Execute<Assets>("[Job].[proc_AssetsLoadAll]");
            GetprocAssetsLoadAllListVm vm = new GetprocAssetsLoadAllListVm
            {
                procAssetss = _mapper.Map<IList<Assets>, IList<GetprocAssetsLoadAllVm>>(procAssetss)
            };

            return vm;
        }
    }
}
