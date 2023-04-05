using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Quiries.procStandardExamReq
{
    public class GetprocStandardExamReqLoadAllVm : IMapFrom<StandardExamReq>
    {
        public string OS_ID { get; set; }
        public string OCAC_Exam { get; set; }
        public bool? Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<StandardExamReq, GetprocStandardExamReqLoadAllVm>();
        }
    }
}
