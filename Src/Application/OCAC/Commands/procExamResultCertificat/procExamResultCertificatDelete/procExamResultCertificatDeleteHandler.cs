using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procExamResultCertificat.procExamResultCertificatDelete.procExamResultCertificatDeleteCommand
{

    /// @author  Shimels Alem  proc_Exam_Result_CertificatDelete stored procedure.


    public class procExamResultCertificatDeleteHandler : IRequestHandler<procExamResultCertificatDeleteCommand, IList<ExamResultCertificat_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procExamResultCertificatDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ExamResultCertificat_ID>> Handle( procExamResultCertificatDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ExamResultCertificat_ID> result = await _procedureAdabter
                .Execute<ExamResultCertificat_ID>("[OCAC].proc_Exam_Result_CertificatDelete", request);
           

            return result;
        }
    }
}
  