using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procExamCentor.procExamCentorDelete.procExamCentorDeleteCommand
{

    /// @author  Shimels Alem  proc_Exam_CentorDelete stored procedure.


    public class procExamCentorDeleteHandler : IRequestHandler<procExamCentorDeleteCommand, IList<ExamCentor_CentorCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procExamCentorDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ExamCentor_CentorCode>> Handle( procExamCentorDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ExamCentor_CentorCode> result = await _procedureAdabter
                .Execute<ExamCentor_CentorCode>("[OCAC].proc_Exam_CentorDelete", request);
           

            return result;
        }
    }
}
  