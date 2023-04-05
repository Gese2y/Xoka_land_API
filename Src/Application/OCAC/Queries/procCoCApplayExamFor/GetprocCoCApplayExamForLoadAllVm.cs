using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Quiries.procCoCApplayExamFor
{
    public class GetprocCoCApplayExamForLoadAllVm : IMapFrom<CoCApplayExamFor>
    {
        public System.Guid Id { get; set; }
        public System.Guid? COC_Cand_ID { get; set; }
        public string OS_ID { get; set; }
        public string Exam_ID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CoCApplayExamFor, GetprocCoCApplayExamForLoadAllVm>();
        }
    }
}
