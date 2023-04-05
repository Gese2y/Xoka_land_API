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

namespace Application.OCAC.Quiries.procExamResult.GetprocExamResultByPrimaryKey
{
    public class GetprocExamResultQueryHandler : IRequestHandler<GetprocExamResultByPrimaryKey, GetprocExamResultLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocExamResultQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocExamResultLoadAllListVm> Handle(GetprocExamResultByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ExamResult> procExamResults = await _procedureAdabter
               .Execute<ExamResult>("[OCAC].[proc_Exam_ResultLoadByPrimaryKey]", request);
            GetprocExamResultLoadAllListVm vm = new GetprocExamResultLoadAllListVm
            {
                procExamResults = _mapper.Map<IList<ExamResult>, IList<GetprocExamResultLoadAllVm>>(procExamResults)
            };

            return vm;
        }
    }
}
