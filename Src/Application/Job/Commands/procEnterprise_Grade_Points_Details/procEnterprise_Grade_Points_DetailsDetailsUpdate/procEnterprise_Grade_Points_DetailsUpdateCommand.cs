using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procEnterprise_Grade_Points_Details.procEnterprise_Grade_Points_DetailsUpdate.procEnterprise_Grade_Points_DetailsUpdateCommand
{

	/// @author  Shimels Alem  proc_Enterprise_RegistrationUpdate stored procedure.

	public class procEnterprise_Grade_Points_DetailsUpdateCommand : IRequest<IList<Enterprise_Grade_Points_Details_ID>>
   {
		public string ID { get; set; }
		public DateTime Date_Graded { get; set; }
		public string Filled_By { get; set; }
		public string JSON_Value { get; set; }
		public string Enterprise_TIN { get; set; }

	}
		
		
		 
}

