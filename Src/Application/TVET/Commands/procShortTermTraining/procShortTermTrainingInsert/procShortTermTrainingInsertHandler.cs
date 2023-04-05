



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;


namespace Application.TVET.Commands.procShortTermTraining.procShortTermTrainingInsert.procShortTermTrainingInsertCommand
{

    /// @author  Shimels Alem  proc_Short_Term_TrainingInsert stored procedure.


    public class procShortTermTrainingInsertHandler : IRequestHandler<procShortTermTrainingInsertCommand, IList<ShortTermTraining_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procShortTermTrainingInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ShortTermTraining_ID>> Handle( procShortTermTrainingInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ShortTermTraining_ID> result = await _procedureAdabter
                .Execute<ShortTermTraining_ID>("[TVET].proc_Short_Term_TrainingInsert", request);
           

            return result;
        }
    }
}
 