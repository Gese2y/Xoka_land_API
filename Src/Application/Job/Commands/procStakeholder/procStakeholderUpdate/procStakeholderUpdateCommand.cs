using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procStakeholder.procStakeholderUpdate.procStakeholderUpdateCommand
{

	/// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.

	public class procStakeholderUpdateCommand : IRequest<IList<Stakeholder_ID>>
   {
		public string Stakeholder_TIN { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Type_Of_Stakeholder { get; set; }
		public Nullable<bool> Is_SME { get; set; }
	}
		
		
		 
}

