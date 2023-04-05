



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;


namespace Application.Trade.Commands.procCapital.procCapitalInsert.procCapitalInsertCommand
{

    /// @author  Shimels Alem  proc_CapitalInsert stored procedure.


    public class procCapitalInsertHandler : IRequestHandler<procCapitalInsertCommand, IList<Capital_CapitalID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCapitalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Capital_CapitalID>> Handle( procCapitalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Capital_CapitalID> result = await _procedureAdabter
                .Execute<Capital_CapitalID>("[Trade].proc_CapitalInsert", request);
           

            return result;
        }
    }
}
 