using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.OCAC.Quiries.procView_Exam_Result_Certificat.GetprocView_Exam_Result_CertificatLoadAll;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procView_Exam_Result_Certificat.GetprocView_Exam_Result_CertificatByPrimaryKey
{
    public class GetprocView_Exam_Result_CertificatQueryHandler : IRequestHandler<GetprocView_Exam_Result_CertificatByPrimaryKey, GetprocView_Exam_Result_CertificatLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocView_Exam_Result_CertificatQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocView_Exam_Result_CertificatLoadAllListVm> Handle(GetprocView_Exam_Result_CertificatByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<View_Exam_Result_Certificat> procView_Exam_Result_Certificats = await _procedureAdabter
               .Execute<View_Exam_Result_Certificat>("[OCAC].[Getproc_View_Exam_Result_CertificatLoadByPrimaryKey_Licence_ID]", request);
            GetprocView_Exam_Result_CertificatLoadAllListVm vm = new GetprocView_Exam_Result_CertificatLoadAllListVm
            {
                procView_Exam_Result_Certificats = _mapper.Map<IList<View_Exam_Result_Certificat>, IList<GetprocView_Exam_Result_CertificatLoadAllVm>>(procView_Exam_Result_Certificats)
            };

            return vm;
        }
    }
}
