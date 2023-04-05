using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procBranch.procBranchUpdate.procBranchUpdateCommand
{

	/// @author  Shimels Alem  proc_BranchUpdate stored procedure.

	public class procBranchUpdateCommand : IRequest<IList<Branch_ID>>
   {
		public System.Guid ID { get; set; }
		public byte[]? Address { get; set; }
		public string Type { get; set; }
		public string Product { get; set; }
	}
		
		
		 
}

