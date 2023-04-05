

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procTemporaryTradeName.procTemporaryTradeNameUpdate.procTemporaryTradeNameUpdateCommand
{

    /// @author  Shimels Alem  proc_Temporary_Trade_NameUpdate stored procedure.


    public class procTemporaryTradeNameUpdateHandler : IRequestHandler<procTemporaryTradeNameUpdateCommand, IList<TemporaryTradeName_TempNameID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTemporaryTradeNameUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TemporaryTradeName_TempNameID>> Handle( procTemporaryTradeNameUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<TemporaryTradeName_TempNameID> result = await _procedureAdabter
                .Execute<TemporaryTradeName_TempNameID>("[Trade].proc_Temporary_Trade_NameUpdate", request);
           

            return result;
        }
    }
}
 