using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procExamResultCertificat.GetprocExamResultCertificatLoadAll;

namespace Application.OCAC.Quiries.procExamResultCertificat.GetprocExamResultCertificatByPrimaryKey
{
    /// @author  Shimels Alem proc_Exam_Result_CertificatLoadByPrimaryKey stored procedure.

    public class GetprocExamResultCertificatByPrimaryKey : IRequest<GetprocExamResultCertificatLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
