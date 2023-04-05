using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procCapital.procCapitalDelete.procCapitalDeleteCommand
{

    /// @author  Shimels Alem  proc_CapitalDelete stored procedure.


    public class procCapitalDeleteHandler : IRequestHandler<procCapitalDeleteCommand, IList<Capital_CapitalID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCapitalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Capital_CapitalID>> Handle( procCapitalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Capital_CapitalID> result = await _procedureAdabter
                .Execute<Capital_CapitalID>("[Trade].proc_CapitalDelete", request);
           

            return result;
        }
    }
}
  