

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procExamResultCertificat.procExamResultCertificatUpdate.procExamResultCertificatUpdateCommand
{

    /// @author  Shimels Alem  proc_Exam_Result_CertificatUpdate stored procedure.


    public class procExamResultCertificatUpdateHandler : IRequestHandler<procExamResultCertificatUpdateCommand, IList<ExamResultCertificat_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procExamResultCertificatUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ExamResultCertificat_ID>> Handle( procExamResultCertificatUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ExamResultCertificat_ID> result = await _procedureAdabter
                .Execute<ExamResultCertificat_ID>("[OCAC].proc_Exam_Result_CertificatUpdate", request);
           

            return result;
        }
    }
}
 