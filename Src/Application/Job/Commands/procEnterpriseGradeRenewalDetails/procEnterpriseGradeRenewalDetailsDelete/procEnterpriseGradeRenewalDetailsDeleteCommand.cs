 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procEnterpriseGradeRenewalDetails.procEnterpriseGradeRenewalDetailsDelete.procEnterpriseGradeRenewalDetailsDeleteCommand
{

    // @author  Shimels Alem  proc_Enterprise_RegistrationDelete stored procedure.

    public class procEnterpriseGradeRenewalDetailsDeleteCommand : IRequest<IList<Enterprise_Grade_Renewal_Details_ID>>
    {
        public System.Guid Ent_Grading_Detail_ID { get; set; }
    }
		
     
		
		 
}
 
 