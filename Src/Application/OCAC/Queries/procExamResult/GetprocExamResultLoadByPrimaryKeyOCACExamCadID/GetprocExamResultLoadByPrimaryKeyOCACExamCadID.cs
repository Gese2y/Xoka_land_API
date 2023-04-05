using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procExamResult.GetprocExamResultLoadAll;

namespace Application.OCAC.Quiries.procExamResult.GetprocExamResultLoadByPrimaryKeyOCACExamCadID
{
    /// @author  Shimels Alem proc_Exam_ResultLoadByPrimaryKey_OCAC_Exam_Cad_ID stored procedure.

    public class GetprocExamResultLoadByPrimaryKeyOCACExamCadID : IRequest<GetprocExamResultLoadAllListVm>
    {
        public System.Guid OCAC_Exam_Cad_ID { get; set; }
    }
}
