

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procMarketOPP.procMarketOPPUpdate.procMarketOPPUpdateCommand
{

    /// @author  Shimels Alem  proc_Market_OPPUpdate stored procedure.


    public class procMarketOPPUpdateHandler : IRequestHandler<procMarketOPPUpdateCommand, IList<MarketOPP_OPPID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMarketOPPUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MarketOPP_OPPID>> Handle( procMarketOPPUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<MarketOPP_OPPID> result = await _procedureAdabter
                .Execute<MarketOPP_OPPID>("[Job].proc_Market_OPPUpdate", request);
           

            return result;
        }
    }
}
 