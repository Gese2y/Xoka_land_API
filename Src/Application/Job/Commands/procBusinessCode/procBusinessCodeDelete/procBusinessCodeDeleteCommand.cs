 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procBusinessCode.procBusinessCodeDelete.procBusinessCodeDeleteCommand
{

    // @author  Shimels Alem  proc_Business_CodeDelete stored procedure.

    public class procBusinessCodeDeleteCommand : IRequest<IList<BusinessCode_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 