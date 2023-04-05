using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procOCACExam.GetprocOCACExamLoadAll;

namespace Application.OCAC.Quiries.procOCACExam.GetprocOCACExamByPrimaryKey
{
    /// @author  Shimels Alem proc_OCAC_ExamLoadByPrimaryKey stored procedure.

    public class GetprocOCACExamByPrimaryKey : IRequest<GetprocOCACExamLoadAllListVm>
    {
        public string Exam_ID { get; set; }
    }
}
