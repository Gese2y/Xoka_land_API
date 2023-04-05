using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procCoCApplayExamFor.GetprocCoCApplayExamForLoadAll;

namespace Application.OCAC.Quiries.procCoCApplayExamFor.GetprocCoCApplayExamForByPrimaryKey
{
    /// @author  Shimels Alem proc_CoCApplay_Exam_ForLoadByPrimaryKey stored procedure.

    public class GetprocCoCApplayExamForByPrimaryKey : IRequest<GetprocCoCApplayExamForLoadAllListVm>
    {
        public System.Guid Id { get; set; }
    }
}
