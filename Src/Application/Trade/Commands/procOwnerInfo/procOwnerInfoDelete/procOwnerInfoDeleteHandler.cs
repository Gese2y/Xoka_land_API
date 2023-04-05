using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procOwnerInfo.procOwnerInfoDelete.procOwnerInfoDeleteCommand
{

    /// @author  Shimels Alem  proc_Owner_InfoDelete stored procedure.


    public class procOwnerInfoDeleteHandler : IRequestHandler<procOwnerInfoDeleteCommand, IList<OwnerInfo_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procOwnerInfoDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OwnerInfo_ID>> Handle( procOwnerInfoDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<OwnerInfo_ID> result = await _procedureAdabter
                .Execute<OwnerInfo_ID>("[Trade].proc_Owner_InfoDelete", request);
           

            return result;
        }
    }
}
  