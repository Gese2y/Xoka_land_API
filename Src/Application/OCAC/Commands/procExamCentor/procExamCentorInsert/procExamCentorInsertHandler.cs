



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;


namespace Application.OCAC.Commands.procExamCentor.procExamCentorInsert.procExamCentorInsertCommand
{

    /// @author  Shimels Alem  proc_Exam_CentorInsert stored procedure.


    public class procExamCentorInsertHandler : IRequestHandler<procExamCentorInsertCommand, IList<ExamCentor_CentorCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procExamCentorInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ExamCentor_CentorCode>> Handle( procExamCentorInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ExamCentor_CentorCode> result = await _procedureAdabter
                .Execute<ExamCentor_CentorCode>("[OCAC].proc_Exam_CentorInsert", request);
           

            return result;
        }
    }
}
 