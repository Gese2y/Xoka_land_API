using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procJob_Opportunity.GetprocJob_OpportunityLoadAll;

namespace Application.Job.Quiries.procJob_Opportunity.GetprocJob_OpportunityByPrimaryKey
{
    /// @author  Shimels Alem proc_MSE_EmployeeLoadByPrimaryKey stored procedure.

    public class GetprocJob_OpportunityByPrimaryKey : IRequest<GetprocJob_OpportunityLoadAllListVm>
    {
        public System.Guid Job_Opportunity_ID { get; set; }

    }
}
