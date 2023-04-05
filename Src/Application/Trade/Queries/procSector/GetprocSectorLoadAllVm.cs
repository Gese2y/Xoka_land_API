using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Quiries.procSector
{
    public class GetprocSectorLoadAllVm : IMapFrom<Sector>
    {
        public string S_Code { get; set; }
        public string Name_AM { get; set; }
        public string Name_EN { get; set; }
        public string Parent { get; set; }
        public string Comm_Bus_Code { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Sector, GetprocSectorLoadAllVm>();
        }
    }
}
