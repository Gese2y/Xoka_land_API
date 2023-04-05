using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Quiries.procBusinessCode
{
    public class GetprocBusinessCodeLoadAllVm : IMapFrom<BusinessCode>
    {
        public string Code { get; set; }
        public string Name_AM { get; set; }
        public string Name_EN { get; set; }
        public string Parent { get; set; }
        public bool? Is_Sector { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<BusinessCode, GetprocBusinessCodeLoadAllVm>();
        }
    }
}
