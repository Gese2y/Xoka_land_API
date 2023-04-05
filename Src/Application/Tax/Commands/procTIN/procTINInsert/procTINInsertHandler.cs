



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;


namespace Application.Tax.Commands.procTIN.procTINInsert.procTINInsertCommand
{

    /// @author  Shimels Alem  proc_TINInsert stored procedure.


    public class procTINInsertHandler : IRequestHandler<procTINInsertCommand, IList<TIN_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTINInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TIN_ID>> Handle( procTINInsertCommand request, CancellationToken cancellationToken)
        {

            IList<TIN_ID> result = await _procedureAdabter
                .Execute<TIN_ID>("[Tax].proc_TINInsert", request);
           

            return result;
        }
    }
}
 