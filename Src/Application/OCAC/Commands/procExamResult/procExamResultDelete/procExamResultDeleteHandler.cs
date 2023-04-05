using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procExamResult.procExamResultDelete.procExamResultDeleteCommand
{

    /// @author  Shimels Alem  proc_Exam_ResultDelete stored procedure.


    public class procExamResultDeleteHandler : IRequestHandler<procExamResultDeleteCommand, IList<ExamResult_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procExamResultDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ExamResult_ID>> Handle( procExamResultDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ExamResult_ID> result = await _procedureAdabter
                .Execute<ExamResult_ID>("[OCAC].proc_Exam_ResultDelete", request);
           

            return result;
        }
    }
}
  