

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procBatch.procBatchUpdate.procBatchUpdateCommand
{

    /// @author  Shimels Alem  proc_BatchUpdate stored procedure.


    public class procBatchUpdateHandler : IRequestHandler<procBatchUpdateCommand, IList<Batch_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBatchUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Batch_Code>> Handle( procBatchUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Batch_Code> result = await _procedureAdabter
                .Execute<Batch_Code>("[TVET].proc_BatchUpdate", request);

            return result;
        }
    }
}
 