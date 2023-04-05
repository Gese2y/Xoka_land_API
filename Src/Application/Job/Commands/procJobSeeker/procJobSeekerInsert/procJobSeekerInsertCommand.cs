


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procJobSeeker.procJobSeekerInsert.procJobSeekerInsertCommand
{

	/// @author  Shimels Alem  proc_Job_SeekerInsert stored procedure.


	public class procJobSeekerInsertCommand : IRequest<IList<JobSeeker_ID>>
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
 
 