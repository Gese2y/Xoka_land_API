


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procEnterpriseGradeRenewalDetails.procEnterpriseGradeRenewalDetailsInsert.procEnterpriseGradeRenewalDetailsInsertCommand
{

	/// @author  Shimels Alem  proc_Enterprise_RegistrationInsert stored procedure.


	public class procEnterpriseGradeRenewalDetailsInsertCommand : IRequest<IList<Enterprise_Grade_Renewal_Details_ID>>
    {
        public System.Guid Ent_Grading_Detail_ID { get; set; }
        public string Code { get; set; }
        public string TIN { get; set; }
        public byte[] Grading_Letter { get; set; }
        public Nullable<System.DateTime> Date_Of_Grade_Issued { get; set; }
        public string Remarks { get; set; }
    }
		
		
		 
}
 
 