 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procEnterpriseModelDetails.procEnterpriseModelDetailsDelete.procEnterpriseModelDetailsDeleteCommand
{

    // @author  Shimels Alem  proc_Enterprise_RegistrationDelete stored procedure.

    public class procEnterpriseModelDetailsDeleteCommand : IRequest<IList<Enterprise_Model_Details_ID>>
    {
        public System.Guid Ent_Model_Detail_ID { get; set; }
    }
		
     
		
		 
}
 
 