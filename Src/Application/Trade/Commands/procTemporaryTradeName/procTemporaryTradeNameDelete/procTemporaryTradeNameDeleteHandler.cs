using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procTemporaryTradeName.procTemporaryTradeNameDelete.procTemporaryTradeNameDeleteCommand
{

    /// @author  Shimels Alem  proc_Temporary_Trade_NameDelete stored procedure.


    public class procTemporaryTradeNameDeleteHandler : IRequestHandler<procTemporaryTradeNameDeleteCommand, IList<TemporaryTradeName_TempNameID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTemporaryTradeNameDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TemporaryTradeName_TempNameID>> Handle( procTemporaryTradeNameDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<TemporaryTradeName_TempNameID> result = await _procedureAdabter
                .Execute<TemporaryTradeName_TempNameID>("[Trade].proc_Temporary_Trade_NameDelete", request);
           

            return result;
        }
    }
}
  