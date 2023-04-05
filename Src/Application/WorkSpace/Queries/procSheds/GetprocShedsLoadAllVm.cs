using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Spatial;
using System.Text;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Quiries.procSheds
{
    public class GetprocShedsLoadAllVm : IMapFrom<Sheds>
    {
        public System.Guid ID { get; set; }
        public Geography? GEO_Location { get; set; }
        public string Type { get; set; }
        public int? Size { get; set; }
        public byte[] Pic { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Sheds, GetprocShedsLoadAllVm>();
        }
    }
}
