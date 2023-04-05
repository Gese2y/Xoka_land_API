using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Quiries.procExamResult
{
    public class GetprocExamResultLoadAllVm : IMapFrom<ExamResult>
    {
        public System.Guid ID { get; set; }
        public System.Guid? OCAC_Exam_Cad_ID { get; set; }
        public double? Result_In_Number { get; set; }
        public string Result_In_Text { get; set; }
        public System.DateTime? Date_of_Exam { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ExamResult, GetprocExamResultLoadAllVm>();
        }
    }
}
