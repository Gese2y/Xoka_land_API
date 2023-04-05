



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;


namespace Application.Tax.Commands.procShareHolderOrMSE.procShareHolderOrMSEInsert.procShareHolderOrMSEInsertCommand
{

    /// @author  Shimels Alem  [proc_Share_Holder(MSE)Insert] stored procedure.


    public class procShareHolderOrMSEInsertHandler : IRequestHandler<procShareHolderOrMSEInsertCommand, IList<ShareHolderOrMSE_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procShareHolderOrMSEInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ShareHolderOrMSE_ID>> Handle( procShareHolderOrMSEInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ShareHolderOrMSE_ID> result = await _procedureAdabter
                .Execute<ShareHolderOrMSE_ID>("[Tax].proc_Share_Holder(MSE)Insert", request);
           

            return result;
        }
    }
}
 