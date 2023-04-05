 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procOrganization.procOrganizationDelete.procOrganizationDeleteCommand
{

    // @author  Shimels Alem  proc_AssetsDelete stored procedure.

    public class procOrganizationDeleteCommand : IRequest<IList<Organization_ID>>
    {

        public string organization_code { get; set; }
    }
		
     
		
		 
}
 
 