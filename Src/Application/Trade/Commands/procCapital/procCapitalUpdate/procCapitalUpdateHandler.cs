

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procCapital.procCapitalUpdate.procCapitalUpdateCommand
{

    /// @author  Shimels Alem  proc_CapitalUpdate stored procedure.


    public class procCapitalUpdateHandler : IRequestHandler<procCapitalUpdateCommand, IList<Capital_CapitalID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCapitalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Capital_CapitalID>> Handle( procCapitalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Capital_CapitalID> result = await _procedureAdabter
                .Execute<Capital_CapitalID>("[Trade].proc_CapitalUpdate", request);
           

            return result;
        }
    }
}
 