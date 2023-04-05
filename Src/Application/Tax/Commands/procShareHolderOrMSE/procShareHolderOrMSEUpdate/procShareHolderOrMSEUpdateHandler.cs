

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Commands.procShareHolderOrMSE.procShareHolderOrMSEUpdate.procShareHolderOrMSEUpdateCommand
{

    /// @author  Shimels Alem  [proc_Share_Holder(MSE)Update] stored procedure.


    public class procShareHolderOrMSEUpdateHandler : IRequestHandler<procShareHolderOrMSEUpdateCommand, IList<ShareHolderOrMSE_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procShareHolderOrMSEUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ShareHolderOrMSE_ID>> Handle( procShareHolderOrMSEUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ShareHolderOrMSE_ID> result = await _procedureAdabter
                .Execute<ShareHolderOrMSE_ID>("[Tax].proc_Share_Holder(MSE)Update", request);
           

            return result;
        }
    }
}
 