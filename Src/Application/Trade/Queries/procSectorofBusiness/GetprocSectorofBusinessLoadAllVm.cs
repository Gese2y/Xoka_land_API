using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Quiries.procSectorofBusiness
{
    public class GetprocSectorofBusinessLoadAllVm : IMapFrom<SectorofBusiness>
    {
        public string TIN { get; set; }
        public string Code { get; set; }
        public bool? Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<SectorofBusiness, GetprocSectorofBusinessLoadAllVm>();
        }
    }
}
