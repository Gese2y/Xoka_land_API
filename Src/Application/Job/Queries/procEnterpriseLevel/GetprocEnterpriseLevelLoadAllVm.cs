using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procEnterpriseLevel
{
    public class GetprocEnterpriseLevelLoadAllVm : IMapFrom<EnterpriseLevel>
    {
        public string Code { get; set; }
        public string name { get; set; }
        public System.Double? Capital { get; set; }
        public string Ent_Level_Type { get; set; }
        public string Size { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<EnterpriseLevel, GetprocEnterpriseLevelLoadAllVm>();
        }
    }
}
