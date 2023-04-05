using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procExamResultCertificat.GetprocExamResultCertificatLoadAll
{
    class GetprocExamResultCertificatLoadAllQueryHandler : IRequestHandler<GetprocExamResultCertificatLoadAllQuery, GetprocExamResultCertificatLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocExamResultCertificatLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocExamResultCertificatLoadAllListVm> Handle(GetprocExamResultCertificatLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ExamResultCertificat> procExamResultCertificats = await _procedureAdabter
               .Execute<ExamResultCertificat>("[OCAC].[proc_Exam_Result_CertificatLoadAll]");
            GetprocExamResultCertificatLoadAllListVm vm = new GetprocExamResultCertificatLoadAllListVm
            {
                procExamResultCertificats = _mapper.Map<IList<ExamResultCertificat>, IList<GetprocExamResultCertificatLoadAllVm>>(procExamResultCertificats)
            };

            return vm;
        }
    }
}
