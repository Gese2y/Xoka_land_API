using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.OCAC.Quiries.procExamResultCertificat.GetprocExamResultCertificatLoadAll;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procExamResultCertificat.GetprocExamResultCertificatByPrimaryKey
{
    public class GetprocExamResultCertificatQueryHandler : IRequestHandler<GetprocExamResultCertificatByPrimaryKey, GetprocExamResultCertificatLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocExamResultCertificatQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocExamResultCertificatLoadAllListVm> Handle(GetprocExamResultCertificatByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ExamResultCertificat> procExamResultCertificats = await _procedureAdabter
               .Execute<ExamResultCertificat>("[OCAC].[proc_Exam_Result_CertificatLoadByPrimaryKey]", request);
            GetprocExamResultCertificatLoadAllListVm vm = new GetprocExamResultCertificatLoadAllListVm
            {
                procExamResultCertificats = _mapper.Map<IList<ExamResultCertificat>, IList<GetprocExamResultCertificatLoadAllVm>>(procExamResultCertificats)
            };

            return vm;
        }
    }
}
