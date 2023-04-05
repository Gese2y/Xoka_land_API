using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Commands.procShareHolderDetail.procShareHolderDetailDelete.procShareHolderDetailDeleteCommand
{

    /// @author  Shimels Alem  proc_Share_Holder_DetailDelete stored procedure.


    public class procShareHolderDetailDeleteHandler : IRequestHandler<procShareHolderDetailDeleteCommand, IList<ShareHolderDetail_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procShareHolderDetailDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ShareHolderDetail_ID>> Handle( procShareHolderDetailDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ShareHolderDetail_ID> result = await _procedureAdabter
                .Execute<ShareHolderDetail_ID>("[Tax].proc_Share_Holder_DetailDelete", request);
           

            return result;
        }
    }
}
  