

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procOCACExamPlan.procOCACExamPlanUpdate.procOCACExamPlanUpdateCommand
{

    /// @author  Shimels Alem  proc_OCAC_Exam_PlanUpdate stored procedure.


    public class procOCACExamPlanUpdateHandler : IRequestHandler<procOCACExamPlanUpdateCommand, IList<OCACExamPlan_OCACExamPlanID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procOCACExamPlanUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OCACExamPlan_OCACExamPlanID>> Handle( procOCACExamPlanUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<OCACExamPlan_OCACExamPlanID> result = await _procedureAdabter
                .Execute<OCACExamPlan_OCACExamPlanID>("[OCAC].proc_OCAC_Exam_PlanUpdate", request);
           

            return result;
        }
    }
}
 