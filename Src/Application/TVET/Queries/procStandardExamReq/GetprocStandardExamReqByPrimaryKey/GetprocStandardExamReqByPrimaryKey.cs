using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procStandardExamReq.GetprocStandardExamReqLoadAll;

namespace Application.TVET.Quiries.procStandardExamReq.GetprocStandardExamReqByPrimaryKey
{
    /// @author  Shimels Alem [sp not found] stored procedure.

    public class GetprocStandardExamReqByPrimaryKey : IRequest<GetprocStandardExamReqLoadAllListVm>
    {
        public string OS_ID { get; set; }
        public string OCAC_Exam { get; set; }
    }
}
