using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procJobSeeker.procJobSeekerUpdate.procJobSeekerUpdateCommand
{

	/// @author  Shimels Alem  proc_Job_SeekerUpdate stored procedure.

	public class procJobSeekerUpdateCommand : IRequest<IList<JobSeeker_ID>>
   {
		public System.Guid ID { get; set; }
		public System.Guid? TIN { get; set; }
		public string First_Name { get; set; }
		public string Last_Name { get; set; }
		public string middle_Nmae { get; set; }
		public string Address { get; set; }
		public string Expernce_Level { get; set; }
		public byte[]? Certfication { get; set; }
		public int? Phone { get; set; }
		public string Job_Type { get; set; }
	}
		
		
		 
}

