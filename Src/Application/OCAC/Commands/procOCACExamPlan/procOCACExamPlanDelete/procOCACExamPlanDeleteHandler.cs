using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procOCACExamPlan.procOCACExamPlanDelete.procOCACExamPlanDeleteCommand
{

    /// @author  Shimels Alem  proc_OCAC_Exam_PlanDelete stored procedure.


    public class procOCACExamPlanDeleteHandler : IRequestHandler<procOCACExamPlanDeleteCommand, IList<OCACExamPlan_OCACExamPlanID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procOCACExamPlanDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OCACExamPlan_OCACExamPlanID>> Handle( procOCACExamPlanDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<OCACExamPlan_OCACExamPlanID> result = await _procedureAdabter
                .Execute<OCACExamPlan_OCACExamPlanID>("[OCAC].proc_OCAC_Exam_PlanDelete", request);
           

            return result;
        }
    }
}
  