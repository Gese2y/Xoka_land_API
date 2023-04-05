using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procJob_Opp_Education_Types.GetprocJob_Opp_Education_TypesLoadAll;

namespace Application.Job.Quiries.procJob_Opp_Education_Types.GetprocJob_Opp_Education_TypesByPrimaryKey
{
    /// @author  Shimels Alem proc_MSE_EmployeeLoadByPrimaryKey stored procedure.

    public class GetprocJob_Opp_Education_TypesByPrimaryKey : IRequest<GetprocJob_Opp_Education_TypesLoadAllListVm>
    {
        public System.Guid Job_Opportunity_ID { get; set; }

    }
}
