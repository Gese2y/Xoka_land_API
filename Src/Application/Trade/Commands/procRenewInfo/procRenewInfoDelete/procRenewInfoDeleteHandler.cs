using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procRenewInfo.procRenewInfoDelete.procRenewInfoDeleteCommand
{

    /// @author  Shimels Alem  proc_Renew_InfoDelete stored procedure.


    public class procRenewInfoDeleteHandler : IRequestHandler<procRenewInfoDeleteCommand, IList<RenewInfo_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procRenewInfoDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<RenewInfo_ID>> Handle( procRenewInfoDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<RenewInfo_ID> result = await _procedureAdabter
                .Execute<RenewInfo_ID>("[Trade].proc_Renew_InfoDelete", request);
           

            return result;
        }
    }
}
  