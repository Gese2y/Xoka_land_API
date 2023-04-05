using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procJob_Assignment_Transaction.procJob_Assignment_TransactionUpdate.procJob_Assignment_TransactionUpdateCommand
{

	/// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.

	public class procJob_Assignment_TransactionUpdateCommand : IRequest<IList<Job_Assignment_Transaction_ID>>
   {
		public System.Guid Transaction_ID { get; set; }
		public Nullable<System.Guid> Job_Opportunity_ID { get; set; }
		public Nullable<System.Guid> Woreda { get; set; }
		public Nullable<double> Number_Of_Person { get; set; }
		public string Approval_Justification_Doc { get; set; }
	}
		
		
		 
}

