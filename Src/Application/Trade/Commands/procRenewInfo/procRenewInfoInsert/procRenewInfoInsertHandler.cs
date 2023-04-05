



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;


namespace Application.Trade.Commands.procRenewInfo.procRenewInfoInsert.procRenewInfoInsertCommand
{

    /// @author  Shimels Alem  proc_Renew_InfoInsert stored procedure.


    public class procRenewInfoInsertHandler : IRequestHandler<procRenewInfoInsertCommand, IList<RenewInfo_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procRenewInfoInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<RenewInfo_ID>> Handle( procRenewInfoInsertCommand request, CancellationToken cancellationToken)
        {

            IList<RenewInfo_ID> result = await _procedureAdabter
                .Execute<RenewInfo_ID>("[Trade].proc_Renew_InfoInsert", request);
           

            return result;
        }
    }
}
 