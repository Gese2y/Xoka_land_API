

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Goods;
using XOKA.Domain.Interfaces;

namespace Application.Goods.Commands.procApplicationForCapitalGoods.procApplicationForCapitalGoodsUpdate.procApplicationForCapitalGoodsUpdateCommand
{

    /// @author  Shimels Alem  proc_Application_For_Capital_GoodsUpdate stored procedure.


    public class procApplicationForCapitalGoodsUpdateHandler : IRequestHandler<procApplicationForCapitalGoodsUpdateCommand, IList<ApplicationForCapitalGoods_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procApplicationForCapitalGoodsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ApplicationForCapitalGoods_ID>> Handle( procApplicationForCapitalGoodsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ApplicationForCapitalGoods_ID> result = await _procedureAdabter
                .Execute<ApplicationForCapitalGoods_ID>("[Goods].proc_Application_For_Capital_GoodsUpdate", request);
           

            return result;
        }
    }
}
 