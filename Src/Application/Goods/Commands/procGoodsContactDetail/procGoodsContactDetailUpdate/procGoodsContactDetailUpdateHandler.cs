

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Goods;
using XOKA.Domain.Interfaces;

namespace Application.Goods.Commands.procGoodsContactDetail.procGoodsContactDetailUpdate.procGoodsContactDetailUpdateCommand
{

    /// @author  Shimels Alem  proc_Goods_Contact_DetailUpdate stored procedure.


    public class procGoodsContactDetailUpdateHandler : IRequestHandler<procGoodsContactDetailUpdateCommand, IList<GoodsContactDetail_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procGoodsContactDetailUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<GoodsContactDetail_ID>> Handle( procGoodsContactDetailUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<GoodsContactDetail_ID> result = await _procedureAdabter
                .Execute<GoodsContactDetail_ID>("[Goods].proc_Goods_Contact_DetailUpdate", request);
           

            return result;
        }
    }
}
 