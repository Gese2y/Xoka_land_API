 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procEnterpriseRegistration.procEnterpriseRegistrationDelete.procEnterpriseRegistrationDeleteCommand
{

    // @author  Shimels Alem  proc_Enterprise_RegistrationDelete stored procedure.

    public class procEnterpriseRegistrationDeleteCommand : IRequest<IList<EnterpriseRegistration_TIN>>
    {
        public string TIN { get; set; }
    }
		
     
		
		 
}
 
 