using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procBatch.procBatchDelete.procBatchDeleteCommand
{

    /// @author  Shimels Alem  proc_BatchDelete stored procedure.


    public class procBatchDeleteHandler : IRequestHandler<procBatchDeleteCommand, IList<Batch_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBatchDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Batch_Code>> Handle( procBatchDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Batch_Code> result = await _procedureAdabter
                .Execute<Batch_Code>("[TVET].proc_BatchDelete", request);
           

            return result;
        }
    }
}
  