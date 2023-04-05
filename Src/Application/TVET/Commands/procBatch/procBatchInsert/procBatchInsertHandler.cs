



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;


namespace Application.TVET.Commands.procBatch.procBatchInsert.procBatchInsertCommand
{

    /// @author  Shimels Alem  proc_BatchInsert stored procedure.


    public class procBatchInsertHandler : IRequestHandler<procBatchInsertCommand, IList<Batch_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBatchInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Batch_Code>> Handle( procBatchInsertCommand request, CancellationToken cancellationToken)
        {
  
            IList<Batch_Code> result = await _procedureAdabter
                    .Execute<Batch_Code>("[TVET].proc_BatchInsert", request);
           
            return result;
        }
    }
}
 