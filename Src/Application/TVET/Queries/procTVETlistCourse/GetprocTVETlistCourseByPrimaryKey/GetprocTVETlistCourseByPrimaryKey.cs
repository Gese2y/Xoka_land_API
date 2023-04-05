using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procTVETlistCourse.GetprocTVETlistCourseLoadAll;

namespace Application.TVET.Quiries.procTVETlistCourse.GetprocTVETlistCourseByPrimaryKey
{
    /// @author  Shimels Alem proc_TVET_list_CourseLoadByPrimaryKey stored procedure.

    public class GetprocTVETlistCourseByPrimaryKey : IRequest<GetprocTVETlistCourseLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
