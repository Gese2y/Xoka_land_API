using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procJob_Position.procJob_PositionUpdate.procJob_PositionUpdateCommand
{

	/// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.

	public class procJob_PositionUpdateCommand : IRequest<IList<Job_Position_Id>>
   {
		public string Job_Position_ID { get; set; }
		public string Position_Name { get; set; }
		public string Parent_ID { get; set; }
	}
		
		
		 
}

