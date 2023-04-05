 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procEnrollment.procEnrollmentDelete.procEnrollmentDeleteCommand
{

    // @author  Shimels Alem  proc_EnrollmentDelete stored procedure.

    public class procEnrollmentDeleteCommand : IRequest<IList<Enrollment_EID>>
    {
        public System.Guid EID { get; set; }
    }
		
     
		
		 
}
 
 