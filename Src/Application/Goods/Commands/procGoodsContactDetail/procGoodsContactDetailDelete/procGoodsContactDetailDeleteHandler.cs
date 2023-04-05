using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Goods;
using XOKA.Domain.Interfaces;

namespace Application.Goods.Commands.procGoodsContactDetail.procGoodsContactDetailDelete.procGoodsContactDetailDeleteCommand
{

    /// @author  Shimels Alem  proc_Goods_Contact_DetailDelete stored procedure.


    public class procGoodsContactDetailDeleteHandler : IRequestHandler<procGoodsContactDetailDeleteCommand, IList<GoodsContactDetail_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procGoodsContactDetailDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<GoodsContactDetail_ID>> Handle( procGoodsContactDetailDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<GoodsContactDetail_ID> result = await _procedureAdabter
                .Execute<GoodsContactDetail_ID>("[Goods].proc_Goods_Contact_DetailDelete", request);
           

            return result;
        }
    }
}
  