using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procShortTermTraining.procShortTermTrainingDelete.procShortTermTrainingDeleteCommand
{

    /// @author  Shimels Alem  proc_Short_Term_TrainingDelete stored procedure.


    public class procShortTermTrainingDeleteHandler : IRequestHandler<procShortTermTrainingDeleteCommand, IList<ShortTermTraining_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procShortTermTrainingDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ShortTermTraining_ID>> Handle( procShortTermTrainingDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ShortTermTraining_ID> result = await _procedureAdabter
                .Execute<ShortTermTraining_ID>("[TVET].proc_Short_Term_TrainingDelete", request);
           

            return result;
        }
    }
}
  