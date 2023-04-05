using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procOCACExamPlan.GetprocOCACExamPlanLoadAll
{
    class GetprocOCACExamPlanLoadAllQueryHandler : IRequestHandler<GetprocOCACExamPlanLoadAllQuery, GetprocOCACExamPlanLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocOCACExamPlanLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOCACExamPlanLoadAllListVm> Handle(GetprocOCACExamPlanLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<OCACExamPlan> procOCACExamPlans = await _procedureAdabter
               .Execute<OCACExamPlan>("[OCAC].[proc_OCAC_Exam_PlanLoadAll]");
            GetprocOCACExamPlanLoadAllListVm vm = new GetprocOCACExamPlanLoadAllListVm
            {
                procOCACExamPlans = _mapper.Map<IList<OCACExamPlan>, IList<GetprocOCACExamPlanLoadAllVm>>(procOCACExamPlans)
            };

            return vm;
        }
    }
}
