using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.OCAC.Quiries.procExamCentor.GetprocExamCentorLoadAll;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procExamCentor.GetprocExamCentorByPrimaryKey
{
    public class GetprocExamCentorQueryHandler : IRequestHandler<GetprocExamCentorByPrimaryKey, GetprocExamCentorLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocExamCentorQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocExamCentorLoadAllListVm> Handle(GetprocExamCentorByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ExamCentor> procExamCentors = await _procedureAdabter
               .Execute<ExamCentor>("[OCAC].[proc_Exam_CentorLoadByPrimaryKey]", request);
            GetprocExamCentorLoadAllListVm vm = new GetprocExamCentorLoadAllListVm
            {
                procExamCentors = _mapper.Map<IList<ExamCentor>, IList<GetprocExamCentorLoadAllVm>>(procExamCentors)
            };

            return vm;
        }
    }
}
