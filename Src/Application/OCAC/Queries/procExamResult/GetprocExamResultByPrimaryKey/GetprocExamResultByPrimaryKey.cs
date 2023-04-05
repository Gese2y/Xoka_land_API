using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procExamResult.GetprocExamResultLoadAll;

namespace Application.OCAC.Quiries.procExamResult.GetprocExamResultByPrimaryKey
{
    /// @author  Shimels Alem proc_Exam_ResultLoadByPrimaryKey stored procedure.

    public class GetprocExamResultByPrimaryKey : IRequest<GetprocExamResultLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
