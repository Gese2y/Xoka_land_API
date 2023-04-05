using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Commands.procMarketOPP.procMarketOPPDelete.procMarketOPPDeleteCommand
{

    /// @author  Shimels Alem  proc_Market_OPPDelete stored procedure.


    public class procMarketOPPDeleteHandler : IRequestHandler<procMarketOPPDeleteCommand, IList<MarketOPP_OPPID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMarketOPPDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MarketOPP_OPPID>> Handle( procMarketOPPDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<MarketOPP_OPPID> result = await _procedureAdabter
                .Execute<MarketOPP_OPPID>("[UnEmployment].proc_Market_OPPDelete", request);
           

            return result;
        }
    }
}
  