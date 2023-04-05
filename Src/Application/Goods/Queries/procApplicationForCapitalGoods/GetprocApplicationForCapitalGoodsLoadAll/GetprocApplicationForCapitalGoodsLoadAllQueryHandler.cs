using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Goods;
using XOKA.Domain.Interfaces;

namespace Application.Goods.Quiries.procApplicationForCapitalGoods.GetprocApplicationForCapitalGoodsLoadAll
{
    class GetprocApplicationForCapitalGoodsLoadAllQueryHandler : IRequestHandler<GetprocApplicationForCapitalGoodsLoadAllQuery, GetprocApplicationForCapitalGoodsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocApplicationForCapitalGoodsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocApplicationForCapitalGoodsLoadAllListVm> Handle(GetprocApplicationForCapitalGoodsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ApplicationForCapitalGoods> procApplicationForCapitalGoodss = await _procedureAdabter
               .Execute<ApplicationForCapitalGoods>("[Goods].[proc_Application_For_Capital_GoodsLoadAll]");
            GetprocApplicationForCapitalGoodsLoadAllListVm vm = new GetprocApplicationForCapitalGoodsLoadAllListVm
            {
                procApplicationForCapitalGoodss = _mapper.Map<IList<ApplicationForCapitalGoods>, IList<GetprocApplicationForCapitalGoodsLoadAllVm>>(procApplicationForCapitalGoodss)
            };

            return vm;
        }
    }
}
