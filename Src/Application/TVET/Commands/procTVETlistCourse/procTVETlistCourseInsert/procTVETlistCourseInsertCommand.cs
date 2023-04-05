


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procTVETlistCourse.procTVETlistCourseInsert.procTVETlistCourseInsertCommand
{

    /// @author  Shimels Alem  proc_TVET_list_CourseInsert stored procedure.


    public class procTVETlistCourseInsertCommand : IRequest<IList<TVETlistCourse_Code>>
    {
        public string Code { get; set; }
        public string Course_Name { get; set; }
        public bool? Is_Active { get; set; }
        public byte Credit_Hour { get; set; }
        public string prerequisites_Course { get; set; }
    }
		
		
		 
}
 
 