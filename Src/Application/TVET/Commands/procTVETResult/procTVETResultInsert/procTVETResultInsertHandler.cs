



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;


namespace Application.TVET.Commands.procTVETResult.procTVETResultInsert.procTVETResultInsertCommand
{

    /// @author  Shimels Alem  proc_TVET_ResultInsert stored procedure.


    public class procTVETResultInsertHandler : IRequestHandler<procTVETResultInsertCommand, IList<TVETResult_RId>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTVETResultInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TVETResult_RId>> Handle( procTVETResultInsertCommand request, CancellationToken cancellationToken)
        {

            IList<TVETResult_RId> result = await _procedureAdabter
                .Execute<TVETResult_RId>("[TVET].proc_TVET_ResultInsert", request);
           

            return result;
        }
    }
}
 