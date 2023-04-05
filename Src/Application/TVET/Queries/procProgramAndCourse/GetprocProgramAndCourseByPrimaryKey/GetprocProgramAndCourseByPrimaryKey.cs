using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procProgramAndCourse.GetprocProgramAndCourseLoadAll;

namespace Application.TVET.Quiries.procProgramAndCourse.GetprocProgramAndCourseByPrimaryKey
{
    /// @author  Shimels Alem proc_Program_And_CourseLoadByPrimaryKey stored procedure.

    public class GetprocProgramAndCourseByPrimaryKey : IRequest<GetprocProgramAndCourseLoadAllListVm>
    {
        public System.Guid P_C_ID { get; set; }
    }
}
