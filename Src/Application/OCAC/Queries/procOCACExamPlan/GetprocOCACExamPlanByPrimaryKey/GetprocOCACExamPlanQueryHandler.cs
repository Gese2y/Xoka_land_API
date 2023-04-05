using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.OCAC.Quiries.procOCACExamPlan.GetprocOCACExamPlanLoadAll;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procOCACExamPlan.GetprocOCACExamPlanByPrimaryKey
{
    public class GetprocOCACExamPlanQueryHandler : IRequestHandler<GetprocOCACExamPlanByPrimaryKey, GetprocOCACExamPlanLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocOCACExamPlanQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOCACExamPlanLoadAllListVm> Handle(GetprocOCACExamPlanByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<OCACExamPlan> procOCACExamPlans = await _procedureAdabter
               .Execute<OCACExamPlan>("[OCAC].[proc_OCAC_Exam_PlanLoadByPrimaryKey]", request);
            GetprocOCACExamPlanLoadAllListVm vm = new GetprocOCACExamPlanLoadAllListVm
            {
                procOCACExamPlans = _mapper.Map<IList<OCACExamPlan>, IList<GetprocOCACExamPlanLoadAllVm>>(procOCACExamPlans)
            };

            return vm;
        }
    }
}
