using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procSub_City_Job_Assignment_Transaction.procSub_City_Job_Assignment_TransactionUpdate.procSub_City_Job_Assignment_TransactionUpdateCommand
{

	/// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.

	public class procSub_City_Job_Assignment_TransactionUpdateCommand : IRequest<IList<Sub_City_Job_Assignment_Transaction_ID>>
   {
		public System.Guid Transaction_ID { get; set; }
		public Nullable<System.Guid> Job_Opportunity_ID { get; set; }
		public Nullable<System.Guid> Sub_City { get; set; }
		public Nullable<double> Number_Of_Person { get; set; }
		public string Approval_Justification_Doc { get; set; }
		public string Created_By { get; set; }
	}
		
		
		 
}

