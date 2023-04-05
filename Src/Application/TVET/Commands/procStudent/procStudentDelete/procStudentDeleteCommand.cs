 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procStudent.procStudentDelete.procStudentDeleteCommand
{

    // @author  Shimels Alem  proc_StudentDelete stored procedure.

    public class procStudentDeleteCommand : IRequest<IList<Student_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 