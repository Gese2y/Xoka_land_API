using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Quiries.procExamResultCertificat
{
    public class GetprocExamResultCertificatLoadAllVm : IMapFrom<ExamResultCertificat>
    {
        public System.Guid ID { get; set; }
        public System.Guid? Exam_Result_Id { get; set; }
        public string TEVET_Program_ID { get; set; }
        public System.DateTime? Date_Issued { get; set; }
        public System.DateTime? Expired_Date { get; set; }
        public bool? Is_Summitted_To_candidate { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ExamResultCertificat, GetprocExamResultCertificatLoadAllVm>();
        }
    }
}
