



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;


namespace Application.Trade.Commands.procProduct.procProductInsert.procProductInsertCommand
{

    /// @author  Shimels Alem  proc_ProductInsert stored procedure.


    public class procProductInsertHandler : IRequestHandler<procProductInsertCommand, IList<Product_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProductInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Product_ID>> Handle( procProductInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Product_ID> result = await _procedureAdabter
                .Execute<Product_ID>("[Trade].proc_ProductInsert", request);
           

            return result;
        }
    }
}
 