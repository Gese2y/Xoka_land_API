using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procCoCApplayExamFor.GetprocCoCApplayExamForLoadAll;

namespace Application.OCAC.Quiries.procCoCApplayExamFor.GetprocCoCApplayExamForLoadByPrimaryKeyCOCCandID
{
    /// @author  Shimels Alem proc_CoCApplay_Exam_ForLoadByPrimaryKey_COC_Cand_ID stored procedure.

    public class GetprocCoCApplayExamForLoadByPrimaryKeyCOCCandID : IRequest<GetprocCoCApplayExamForLoadAllListVm>
    {
        public System.Guid COC_Cand_ID { get; set; }
    }
}
