using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.OCAC.Quiries.procView_Exam_Result_Certificat.GetprocView_Exam_Result_CertificatLoadAll;

namespace Application.OCAC.Quiries.procView_Exam_Result_Certificat.GetprocView_Exam_Result_CertificatByPrimaryKey
{
    /// @author  Shimels Alem proc_Exam_Result_CertificatLoadByPrimaryKey stored procedure.

    public class GetprocView_Exam_Result_CertificatByPrimaryKey : IRequest<GetprocView_Exam_Result_CertificatLoadAllListVm>
    {
        public System.Guid Licence_Id { get; set; }
    }
}
