 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Commands.procEmployeeTINInfo.procEmployeeTINInfoDelete.procEmployeeTINInfoDeleteCommand
{

    // @author  Shimels Alem  proc_Employee_TIN_InfoDelete stored procedure.

    public class procEmployeeTINInfoDeleteCommand : IRequest<IList<EmployeeTINInfo_EmpTINID>>
    {
        public System.Guid Emp_TIN_ID { get; set; }
    }
		
     
		
		 
}
 
 