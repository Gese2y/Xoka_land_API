using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procMSEwarning.procMSEwarningUpdate.procMSEwarningUpdateCommand
{

	/// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.

	public class procMSEwarningUpdateCommand : IRequest<IList<MSEwarning_ID>>
   {
		public System.Guid ID { get; set; }
		public string TIN { get; set; }
		public string Warning_Code { get; set; }
		public System.DateTime? Date_Issued { get; set; }
		public string Description { get; set; }
		public string Status { get; set; }

		public byte[] Warning_Letter_Doc { get; set; }
	}
		
		
		 
}

