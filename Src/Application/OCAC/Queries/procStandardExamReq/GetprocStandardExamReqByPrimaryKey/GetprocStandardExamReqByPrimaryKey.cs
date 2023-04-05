using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procStandardExamReq.GetprocStandardExamReqLoadAll;

namespace Application.OCAC.Quiries.procStandardExamReq.GetprocStandardExamReqByPrimaryKey
{
    /// @author  Shimels Alem proc_Standard_Exam_ReqLoadByPrimaryKey stored procedure.

    public class GetprocStandardExamReqByPrimaryKey : IRequest<GetprocStandardExamReqLoadAllListVm>
    {
        public string OS_ID { get; set; }
        public string OCAC_Exam { get; set; }
    }
}
