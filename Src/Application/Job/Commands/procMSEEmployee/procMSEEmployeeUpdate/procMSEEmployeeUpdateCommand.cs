using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procMSEEmployee.procMSEEmployeeUpdate.procMSEEmployeeUpdateCommand
{

	/// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.

	public class procMSEEmployeeUpdateCommand : IRequest<IList<MSEEmployee_ID>>
   {
		public System.Guid ID { get; set; }
		public string MSE_TIN { get; set; }
		public string Employee_TIN { get; set; }
		public string Full_Name { get; set; }
		public string Gender { get; set; }
		public System.DateTime? Date_of_Birth { get; set; }
		public decimal? Basic_Salary { get; set; }
		public string MSE_Emplyee_Status { get; set; }

		public string Education_Level { get; set; }
		public bool Is_Disabled { get; set; }
		public bool Is_Refugee { get; set; }
		public bool Is_Returnee { get; set; }
		public bool Has_HIV { get; set; }
		public string Kebele_ID { get; set; }
		public DateTime TerminatedDate { get; set; }
	}
		
		
		 
}

