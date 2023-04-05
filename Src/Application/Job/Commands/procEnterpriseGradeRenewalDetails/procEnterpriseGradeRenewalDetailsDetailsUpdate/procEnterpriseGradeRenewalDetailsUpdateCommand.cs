using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procEnterpriseGradeRenewalDetails.procEnterpriseGradeRenewalDetailsUpdate.procEnterpriseGradeRenewalDetailsUpdateCommand
{

	/// @author  Shimels Alem  proc_Enterprise_RegistrationUpdate stored procedure.

	public class procEnterpriseGradeRenewalDetailsUpdateCommand : IRequest<IList<Enterprise_Grade_Renewal_Details_ID>>
   {
		public System.Guid Ent_Grading_Detail_ID { get; set; }
		public string Code { get; set; }
		public string TIN { get; set; }
		public byte[] Grading_Letter { get; set; }
		public Nullable<System.DateTime> Date_Of_Grade_Issued { get; set; }
		public string Remarks { get; set; }

	}
		
		
		 
}

