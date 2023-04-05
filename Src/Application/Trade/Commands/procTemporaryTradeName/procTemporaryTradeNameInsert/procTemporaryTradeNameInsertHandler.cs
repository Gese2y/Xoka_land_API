



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;


namespace Application.Trade.Commands.procTemporaryTradeName.procTemporaryTradeNameInsert.procTemporaryTradeNameInsertCommand
{

    /// @author  Shimels Alem  proc_Temporary_Trade_NameInsert stored procedure.


    public class procTemporaryTradeNameInsertHandler : IRequestHandler<procTemporaryTradeNameInsertCommand, IList<TemporaryTradeName_TempNameID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTemporaryTradeNameInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TemporaryTradeName_TempNameID>> Handle( procTemporaryTradeNameInsertCommand request, CancellationToken cancellationToken)
        {

            IList<TemporaryTradeName_TempNameID> result = await _procedureAdabter
                .Execute<TemporaryTradeName_TempNameID>("[Trade].proc_Temporary_Trade_NameInsert", request);
           

            return result;
        }
    }
}
 