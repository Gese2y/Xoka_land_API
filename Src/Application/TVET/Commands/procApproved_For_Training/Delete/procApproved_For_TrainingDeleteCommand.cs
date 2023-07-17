 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procApproved_For_Training.Delete.procApproved_For_TrainingDeleteCommand
{

    // @author  Shimels Alem  proc_AttendanceDelete stored procedure.

    public class procApproved_For_TrainingDeleteCommand : IRequest<IList<Approved_For_TrainingID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 