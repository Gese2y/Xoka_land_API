using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Quiries.procOCACExam
{
    public class GetprocOCACExamLoadAllVm : IMapFrom<OCACExam>
    {
        public string Exam_ID { get; set; }
        public string Name { get; set; }
        public string Exam_Type { get; set; }
        public string Pass_Mark { get; set; }
        public bool? Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<OCACExam, GetprocOCACExamLoadAllVm>();
        }
    }
}
