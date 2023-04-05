 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.UnEmployment;

namespace Application.UnEmployment.Commands.procunEmployeeRequest.procunEmployeeRequestDelete.procunEmployeeRequestDeleteCommand
{

    // @author  Shimels Alem  proc_unEmployeeRequestDelete stored procedure.

    public class procunEmployeeRequestDeleteCommand : IRequest<IList<unEmployeeRequest_Id>>
    {
        public System.Guid Id { get; set; }
    }
		
     
		
		 
}
 
 