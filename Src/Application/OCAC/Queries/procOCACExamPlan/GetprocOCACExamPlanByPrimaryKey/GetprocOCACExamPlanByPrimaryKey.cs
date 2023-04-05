using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procOCACExamPlan.GetprocOCACExamPlanLoadAll;

namespace Application.OCAC.Quiries.procOCACExamPlan.GetprocOCACExamPlanByPrimaryKey
{
    /// @author  Shimels Alem proc_OCAC_Exam_PlanLoadByPrimaryKey stored procedure.

    public class GetprocOCACExamPlanByPrimaryKey : IRequest<GetprocOCACExamPlanLoadAllListVm>
    {
        public System.Guid OCAC_Exam_Plan_ID { get; set; }
    }
}
