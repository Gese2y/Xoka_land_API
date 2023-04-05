using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procBusinessCode.procBusinessCodeUpdate.procBusinessCodeUpdateCommand
{

	/// @author  Shimels Alem  proc_Business_CodeUpdate stored procedure.

	public class procBusinessCodeUpdateCommand : IRequest<IList<BusinessCode_Code>>
   {
		public string Code { get; set; }
		public string Name_AM { get; set; }
		public string Name_EN { get; set; }
		public string Parent { get; set; }
		public bool? Is_Sector { get; set; }
	}
		
		
		 
}

