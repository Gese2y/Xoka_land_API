using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Quiries.procOccupationalStandard
{
    public class GetprocOccupationalStandardLoadAllVm : IMapFrom<OccupationalStandard>
    {
        public string OS_ID { get; set; }
        public string Name { get; set; }
        public System.Guid? Parent { get; set; }
        public string Version { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public bool? IS_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<OccupationalStandard, GetprocOccupationalStandardLoadAllVm>();
        }
    }
}
