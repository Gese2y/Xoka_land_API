 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procTVETlistCourse.procTVETlistCourseDelete.procTVETlistCourseDeleteCommand
{

    // @author  Shimels Alem  proc_TVET_list_CourseDelete stored procedure.

    public class procTVETlistCourseDeleteCommand : IRequest<IList<TVETlistCourse_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 