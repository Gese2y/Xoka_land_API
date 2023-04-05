using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procListofCourse.GetprocListofCourseLoadAll;

namespace Application.TVET.Quiries.procListofCourse.GetprocListofCourseByPrimaryKey
{
    /// @author  Shimels Alem proc_List_of_CourseLoadByPrimaryKey stored procedure.

    public class GetprocListofCourseByPrimaryKey : IRequest<GetprocListofCourseLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
