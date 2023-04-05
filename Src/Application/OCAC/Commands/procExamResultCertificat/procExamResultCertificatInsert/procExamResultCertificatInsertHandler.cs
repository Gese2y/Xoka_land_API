



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;


namespace Application.OCAC.Commands.procExamResultCertificat.procExamResultCertificatInsert.procExamResultCertificatInsertCommand
{

    /// @author  Shimels Alem  proc_Exam_Result_CertificatInsert stored procedure.


    public class procExamResultCertificatInsertHandler : IRequestHandler<procExamResultCertificatInsertCommand, IList<ExamResultCertificat_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procExamResultCertificatInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ExamResultCertificat_ID>> Handle( procExamResultCertificatInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ExamResultCertificat_ID> result = await _procedureAdabter
                .Execute<ExamResultCertificat_ID>("[OCAC].proc_Exam_Result_CertificatInsert", request);
           

            return result;
        }
    }
}
 