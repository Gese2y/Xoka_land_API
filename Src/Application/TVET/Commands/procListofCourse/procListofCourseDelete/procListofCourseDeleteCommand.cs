 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procListofCourse.procListofCourseDelete.procListofCourseDeleteCommand
{

    // @author  Shimels Alem  proc_List_of_CourseDelete stored procedure.

    public class procListofCourseDeleteCommand : IRequest<IList<ListofCourse_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 