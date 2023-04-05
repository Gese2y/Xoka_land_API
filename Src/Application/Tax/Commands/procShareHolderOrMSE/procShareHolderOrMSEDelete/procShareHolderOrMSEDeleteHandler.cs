using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Commands.procShareHolderOrMSE.procShareHolderOrMSEDelete.procShareHolderOrMSEDeleteCommand
{

    /// @author  Shimels Alem  [proc_Share_Holder(MSE)Delete] stored procedure.


    public class procShareHolderOrMSEDeleteHandler : IRequestHandler<procShareHolderOrMSEDeleteCommand, IList<ShareHolderOrMSE_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procShareHolderOrMSEDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ShareHolderOrMSE_ID>> Handle( procShareHolderOrMSEDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ShareHolderOrMSE_ID> result = await _procedureAdabter
                .Execute<ShareHolderOrMSE_ID>("[Tax].proc_Share_Holder(MSE)Delete", request);
           

            return result;
        }
    }
}
  