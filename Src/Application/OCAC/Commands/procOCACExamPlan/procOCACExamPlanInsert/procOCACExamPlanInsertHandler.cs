



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;


namespace Application.OCAC.Commands.procOCACExamPlan.procOCACExamPlanInsert.procOCACExamPlanInsertCommand
{

    /// @author  Shimels Alem  proc_OCAC_Exam_PlanInsert stored procedure.


    public class procOCACExamPlanInsertHandler : IRequestHandler<procOCACExamPlanInsertCommand, IList<OCACExamPlan_OCACExamPlanID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procOCACExamPlanInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OCACExamPlan_OCACExamPlanID>> Handle( procOCACExamPlanInsertCommand request, CancellationToken cancellationToken)
        {

            IList<OCACExamPlan_OCACExamPlanID> result = await _procedureAdabter
                .Execute<OCACExamPlan_OCACExamPlanID>("[OCAC].proc_OCAC_Exam_PlanInsert", request);
           

            return result;
        }
    }
}
 