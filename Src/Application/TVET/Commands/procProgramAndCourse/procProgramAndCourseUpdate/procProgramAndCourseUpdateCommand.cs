using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procProgramAndCourse.procProgramAndCourseUpdate.procProgramAndCourseUpdateCommand
{

	/// @author  Shimels Alem  proc_Program_And_CourseUpdate stored procedure.

	public class procProgramAndCourseUpdateCommand : IRequest<IList<ProgramAndCourse_PCID>>
   {
        public System.Guid P_C_ID { get; set; }
        public string Program_code { get; set; }
        public string Course_ID { get; set; }
        public bool? IS_Active { get; set; }
        public string Remarks { get; set; }
    }
		
		
		 
}

