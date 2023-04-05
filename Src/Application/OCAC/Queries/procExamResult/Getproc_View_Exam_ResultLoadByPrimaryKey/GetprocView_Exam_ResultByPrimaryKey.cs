using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procView_Exam_Result.GetprocView_Exam_ResultLoadAll;

namespace Application.OCAC.Quiries.procView_Exam_Result.GetprocView_Exam_ResultByPrimaryKey
{
    /// @author  Shimels Alem proc_Exam_ResultLoadByPrimaryKey stored procedure.

    public class GetprocView_Exam_ResultByPrimaryKey : IRequest<GetprocView_Exam_ResultLoadAllListVm>
    {
        public System.Guid Licence_Id { get; set; }
    }
}
