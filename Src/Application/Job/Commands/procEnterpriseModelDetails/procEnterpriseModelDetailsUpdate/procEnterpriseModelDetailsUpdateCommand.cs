using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procEnterpriseModelDetails.procEnterpriseModelDetailsUpdate.procEnterpriseModelDetailsUpdateCommand
{

	/// @author  Shimels Alem  proc_Enterprise_RegistrationUpdate stored procedure.

	public class procEnterpriseModelDetailsUpdateCommand : IRequest<IList<Enterprise_Model_Details_ID>>
   {
		public System.Guid Ent_Model_Detail_ID { get; set; }
		public string TIN { get; set; }
		public byte[] Model_Evaluation_Letter { get; set; }
		public Nullable<System.DateTime> Date_Of_Model_Selection { get; set; }
		public Nullable<double> Point_Earned { get; set; }
		public string Remarks { get; set; }

	}
		
		
		 
}

