 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.UnEmployment;

namespace Application.UnEmployment.Commands.procUnEmployee.procUnEmployeeDelete.procUnEmployeeDeleteCommand
{

    // @author  Shimels Alem  proc_UnEmployeeDelete stored procedure.

    public class procUnEmployeeDeleteCommand : IRequest<IList<UnEmployee_TIN>>
    {
        public string Vital_ID { get; set; }
    }
		
     
		
		 
}
 
 