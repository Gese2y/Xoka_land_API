 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procProgramAndCourse.procProgramAndCourseDelete.procProgramAndCourseDeleteCommand
{

    // @author  Shimels Alem  proc_Program_And_CourseDelete stored procedure.

    public class procProgramAndCourseDeleteCommand : IRequest<IList<ProgramAndCourse_PCID>>
    {
        public System.Guid P_C_ID { get; set; }
    }
		
     
		
		 
}
 
 