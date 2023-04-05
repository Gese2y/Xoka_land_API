using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procExamCentor.GetprocExamCentorLoadAll
{
    class GetprocExamCentorLoadAllQueryHandler : IRequestHandler<GetprocExamCentorLoadAllQuery, GetprocExamCentorLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocExamCentorLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocExamCentorLoadAllListVm> Handle(GetprocExamCentorLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ExamCentor> procExamCentors = await _procedureAdabter
               .Execute<ExamCentor>("[OCAC].[proc_Exam_CentorLoadAll]");
            GetprocExamCentorLoadAllListVm vm = new GetprocExamCentorLoadAllListVm
            {
                procExamCentors = _mapper.Map<IList<ExamCentor>, IList<GetprocExamCentorLoadAllVm>>(procExamCentors)
            };

            return vm;
        }
    }
}
