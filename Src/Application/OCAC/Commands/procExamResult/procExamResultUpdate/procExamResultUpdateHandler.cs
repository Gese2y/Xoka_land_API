

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procExamResult.procExamResultUpdate.procExamResultUpdateCommand
{

    /// @author  Shimels Alem  proc_Exam_ResultUpdate stored procedure.


    public class procExamResultUpdateHandler : IRequestHandler<procExamResultUpdateCommand, IList<ExamResult_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procExamResultUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ExamResult_ID>> Handle( procExamResultUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ExamResult_ID> result = await _procedureAdabter
                .Execute<ExamResult_ID>("[OCAC].proc_Exam_ResultUpdate", request);
           

            return result;
        }
    }
}
 