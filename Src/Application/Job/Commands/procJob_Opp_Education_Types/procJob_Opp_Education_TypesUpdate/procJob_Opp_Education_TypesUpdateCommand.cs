using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procJob_Opp_Education_Types.procJob_Opp_Education_TypesUpdate.procJob_Opp_Education_TypesUpdateCommand
{

	/// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.

	public class procJob_Opp_Education_TypesUpdateCommand : IRequest<IList<Job_Opp_Education_Types_Id>>
   {
        public System.Guid Job_Opportunity_ID { get; set; }
        public string Job_Education_Type_ID { get; set; }
       
    }
		
		
		 
}

