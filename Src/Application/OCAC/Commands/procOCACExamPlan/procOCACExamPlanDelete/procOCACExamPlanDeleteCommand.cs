 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procOCACExamPlan.procOCACExamPlanDelete.procOCACExamPlanDeleteCommand
{

    // @author  Shimels Alem  proc_OCAC_Exam_PlanDelete stored procedure.

    public class procOCACExamPlanDeleteCommand : IRequest<IList<OCACExamPlan_OCACExamPlanID>>
    {
        public System.Guid OCAC_Exam_Plan_ID { get; set; }
    }
		
     
		
		 
}
 
 