



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;


namespace Application.OCAC.Commands.procExamResult.procExamResultInsert.procExamResultInsertCommand
{

    /// @author  Shimels Alem  proc_Exam_ResultInsert stored procedure.


    public class procExamResultInsertHandler : IRequestHandler<procExamResultInsertCommand, IList<ExamResult_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procExamResultInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ExamResult_ID>> Handle( procExamResultInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ExamResult_ID> result = await _procedureAdabter
                .Execute<ExamResult_ID>("[OCAC].proc_Exam_ResultInsert", request);
           

            return result;
        }
    }
}
 