using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procExamCentor.GetprocExamCentorLoadAll;

namespace Application.OCAC.Quiries.procExamCentor.GetprocExamCentorByPrimaryKey
{
    /// @author  Shimels Alem proc_Exam_CentorLoadByPrimaryKey stored procedure.

    public class GetprocExamCentorByPrimaryKey : IRequest<GetprocExamCentorLoadAllListVm>
    {
        public string Centor_Code { get; set; }
    }
}
