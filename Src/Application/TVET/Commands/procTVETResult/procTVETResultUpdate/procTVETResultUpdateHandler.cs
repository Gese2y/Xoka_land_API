

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procTVETResult.procTVETResultUpdate.procTVETResultUpdateCommand
{

    /// @author  Shimels Alem  proc_TVET_ResultUpdate stored procedure.


    public class procTVETResultUpdateHandler : IRequestHandler<procTVETResultUpdateCommand, IList<TVETResult_RId>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTVETResultUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TVETResult_RId>> Handle( procTVETResultUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<TVETResult_RId> result = await _procedureAdabter
                .Execute<TVETResult_RId>("[TVET].proc_TVET_ResultUpdate", request);
           

            return result;
        }
    }
}
 