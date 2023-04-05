using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Spatial;
using System.Text;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Quiries.procShedStatus
{
    public class GetprocShedStatusLoadAllVm : IMapFrom<ShedStatus>
    {
        public System.Guid ID { get; set; }
        public byte[] Stutus { get; set; }
        public Geography Construction_Place { get; set; }
        public System.Decimal? Cost { get; set; }
        public string Contactor { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ShedStatus, GetprocShedStatusLoadAllVm>();
        }
    }
}
