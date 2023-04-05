using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procAssets.GetprocAssetsLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procAssets.GetprocAssetsByPrimaryKey
{
    public class GetprocAssetsQueryHandler : IRequestHandler<GetprocAssetsByPrimaryKey, GetprocAssetsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocAssetsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAssetsLoadAllListVm> Handle(GetprocAssetsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Assets> procAssetss = await _procedureAdabter
               .Execute<Assets>("[Job].[proc_AssetsLoadByPrimaryKey]", request);
            GetprocAssetsLoadAllListVm vm = new GetprocAssetsLoadAllListVm
            {
                procAssetss = _mapper.Map<IList<Assets>, IList<GetprocAssetsLoadAllVm>>(procAssetss)
            };

            return vm;
        }
    }
}
