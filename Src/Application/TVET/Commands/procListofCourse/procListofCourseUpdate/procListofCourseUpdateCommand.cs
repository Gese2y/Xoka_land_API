using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procListofCourse.procListofCourseUpdate.procListofCourseUpdateCommand
{

	/// @author  Shimels Alem  proc_List_of_CourseUpdate stored procedure.

    public class procListofCourseUpdateCommand : IRequest<IList<ListofCourse_ID>>
   {
        public System.Guid ID { get; set; }
        public string Course_Name { get; set; }
        public string IS_Active { get; set; }
        public System.Guid? TVET_ID { get; set; }
        public string Credit_Hour { get; set; }
    }
		
		
		 
}

