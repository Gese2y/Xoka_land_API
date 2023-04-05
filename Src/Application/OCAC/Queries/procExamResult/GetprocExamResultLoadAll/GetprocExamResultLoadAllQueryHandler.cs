using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procExamResult.GetprocExamResultLoadAll
{
    class GetprocExamResultLoadAllQueryHandler : IRequestHandler<GetprocExamResultLoadAllQuery, GetprocExamResultLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocExamResultLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocExamResultLoadAllListVm> Handle(GetprocExamResultLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ExamResult> procExamResults = await _procedureAdabter
               .Execute<ExamResult>("[OCAC].[proc_Exam_ResultLoadAll]");
            GetprocExamResultLoadAllListVm vm = new GetprocExamResultLoadAllListVm
            {
                procExamResults = _mapper.Map<IList<ExamResult>, IList<GetprocExamResultLoadAllVm>>(procExamResults)
            };

            return vm;
        }
    }
}
