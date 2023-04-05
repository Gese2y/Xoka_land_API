using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procRenewInfoChange.procRenewInfoChangeDelete.procRenewInfoChangeDeleteCommand
{

    /// @author  Shimels Alem  proc_Renew_Info_ChangeDelete stored procedure.


    public class procRenewInfoChangeDeleteHandler : IRequestHandler<procRenewInfoChangeDeleteCommand, IList<RenewInfoChange_ChangeID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procRenewInfoChangeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<RenewInfoChange_ChangeID>> Handle( procRenewInfoChangeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<RenewInfoChange_ChangeID> result = await _procedureAdabter
                .Execute<RenewInfoChange_ChangeID>("[Trade].proc_Renew_Info_ChangeDelete", request);
           

            return result;
        }
    }
}
  