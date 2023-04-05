using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.OCAC.Quiries.procExamResult.GetprocExamResultLoadAll;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procExamResult.GetprocExamResultLoadByPrimaryKeyOCACExamCadID
{
    public class GetprocExamResultQueryHandler : IRequestHandler<GetprocExamResultLoadByPrimaryKeyOCACExamCadID, GetprocExamResultLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocExamResultQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocExamResultLoadAllListVm> Handle(GetprocExamResultLoadByPrimaryKeyOCACExamCadID request, CancellationToken cancellationToken)
        {
           
            IList<ExamResult> procExamResults = await _procedureAdabter
               .Execute<ExamResult>("[OCAC].[proc_Exam_ResultLoadByPrimaryKey_OCAC_Exam_Cad_ID]", request);
            GetprocExamResultLoadAllListVm vm = new GetprocExamResultLoadAllListVm
            {
                procExamResults = _mapper.Map<IList<ExamResult>, IList<GetprocExamResultLoadAllVm>>(procExamResults)
            };

            return vm;
        }
    }
}
