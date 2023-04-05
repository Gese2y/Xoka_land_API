using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Goods;
using XOKA.Domain.Interfaces;

namespace Application.Goods.Commands.procApplicationForCapitalGoods.procApplicationForCapitalGoodsDelete.procApplicationForCapitalGoodsDeleteCommand
{

    /// @author  Shimels Alem  proc_Application_For_Capital_GoodsDelete stored procedure.


    public class procApplicationForCapitalGoodsDeleteHandler : IRequestHandler<procApplicationForCapitalGoodsDeleteCommand, IList<ApplicationForCapitalGoods_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procApplicationForCapitalGoodsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ApplicationForCapitalGoods_ID>> Handle( procApplicationForCapitalGoodsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ApplicationForCapitalGoods_ID> result = await _procedureAdabter
                .Execute<ApplicationForCapitalGoods_ID>("[Goods].proc_Application_For_Capital_GoodsDelete", request);
           

            return result;
        }
    }
}
  