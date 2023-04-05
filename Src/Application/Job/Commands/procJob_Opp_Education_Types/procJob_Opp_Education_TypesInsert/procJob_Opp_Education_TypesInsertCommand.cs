


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procJob_Opp_Education_Types.procJob_Opp_Education_TypesInsert.procJob_Opp_Education_TypesInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procJob_Opp_Education_TypesInsertCommand : IRequest<IList<Job_Opp_Education_Types_Id>>
    {
        public System.Guid Job_Opportunity_ID { get; set; }
        public string Job_Education_Type_ID { get; set; }
    }
		
		
		 
}
 
 