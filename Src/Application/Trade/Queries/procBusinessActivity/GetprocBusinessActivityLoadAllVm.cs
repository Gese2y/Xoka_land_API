using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Quiries.procBusinessActivity
{
    public class GetprocBusinessActivityLoadAllVm : IMapFrom<BusinessActivity>
    {
        public string Code { get; set; }
        public string TIN { get; set; }
        public string Bus_Activity_code { get; set; }
        public string Activity_Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<BusinessActivity, GetprocBusinessActivityLoadAllVm>();
        }
    }
}
