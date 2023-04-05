using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Goods.Quiries.procGoodsContactDetail.GetprocGoodsContactDetailLoadAll;
using XOKA.Domain.Entities.Goods;
using XOKA.Domain.Interfaces;

namespace Application.Goods.Quiries.procGoodsContactDetail.GetprocGoodsContactDetailByPrimaryKey
{
    public class GetprocGoodsContactDetailQueryHandler : IRequestHandler<GetprocGoodsContactDetailByPrimaryKey, GetprocGoodsContactDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocGoodsContactDetailQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocGoodsContactDetailLoadAllListVm> Handle(GetprocGoodsContactDetailByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<GoodsContactDetail> procGoodsContactDetails = await _procedureAdabter
               .Execute<GoodsContactDetail>("[Goods].[proc_Goods_Contact_DetailLoadByPrimaryKey]", request);
            GetprocGoodsContactDetailLoadAllListVm vm = new GetprocGoodsContactDetailLoadAllListVm
            {
                procGoodsContactDetails = _mapper.Map<IList<GoodsContactDetail>, IList<GetprocGoodsContactDetailLoadAllVm>>(procGoodsContactDetails)
            };

            return vm;
        }
    }
}
