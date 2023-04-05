 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procEnterpriseLevel.procEnterpriseLevelDelete.procEnterpriseLevelDeleteCommand
{

    // @author  Shimels Alem  proc_Enterprise_LevelDelete stored procedure.

    public class procEnterpriseLevelDeleteCommand : IRequest<IList<EnterpriseLevel_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 