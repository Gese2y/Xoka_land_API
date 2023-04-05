

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procTVETProviders.procTVETProvidersUpdate.procTVETProvidersUpdateCommand
{

    /// @author  Shimels Alem  proc_TVET_ProvidersUpdate stored procedure.


    public class procTVETProvidersUpdateHandler : IRequestHandler<procTVETProvidersUpdateCommand, IList<TVETProviders_ProviderCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTVETProvidersUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TVETProviders_ProviderCode>> Handle( procTVETProvidersUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<TVETProviders_ProviderCode> result = await _procedureAdabter
                .Execute<TVETProviders_ProviderCode>("[TVET].proc_TVET_ProvidersUpdate", request);
           

            return result;
        }
    }
}
 