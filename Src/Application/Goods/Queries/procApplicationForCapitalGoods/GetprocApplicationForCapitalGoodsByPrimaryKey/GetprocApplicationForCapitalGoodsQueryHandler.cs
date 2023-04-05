using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Goods.Quiries.procApplicationForCapitalGoods.GetprocApplicationForCapitalGoodsLoadAll;
using XOKA.Domain.Entities.Goods;
using XOKA.Domain.Interfaces;

namespace Application.Goods.Quiries.procApplicationForCapitalGoods.GetprocApplicationForCapitalGoodsByPrimaryKey
{
    public class GetprocApplicationForCapitalGoodsQueryHandler : IRequestHandler<GetprocApplicationForCapitalGoodsByPrimaryKey, GetprocApplicationForCapitalGoodsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocApplicationForCapitalGoodsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocApplicationForCapitalGoodsLoadAllListVm> Handle(GetprocApplicationForCapitalGoodsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ApplicationForCapitalGoods> procApplicationForCapitalGoodss = await _procedureAdabter
               .Execute<ApplicationForCapitalGoods>("[Goods].[proc_Application_For_Capital_GoodsLoadByPrimaryKey]", request);
            GetprocApplicationForCapitalGoodsLoadAllListVm vm = new GetprocApplicationForCapitalGoodsLoadAllListVm
            {
                procApplicationForCapitalGoodss = _mapper.Map<IList<ApplicationForCapitalGoods>, IList<GetprocApplicationForCapitalGoodsLoadAllVm>>(procApplicationForCapitalGoodss)
            };

            return vm;
        }
    }
}
