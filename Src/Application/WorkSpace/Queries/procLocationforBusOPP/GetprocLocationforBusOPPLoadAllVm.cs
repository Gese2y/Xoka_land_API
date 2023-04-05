using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Quiries.procLocationforBusOPP
{
    public class GetprocLocationforBusOPPLoadAllVm : IMapFrom<LocationforBusOPP>
    {
        public System.Guid BUS_OPP_Loc_Code { get; set; }
        public System.Guid BUS_OPP_ID { get; set; }
        public System.Guid Region { get; set; }
        public System.Guid Zone { get; set; }
        public System.Guid Woreda { get; set; }
        public int JobOpen_For_ENT { get; set; }
        public int Job_Open_For_Job_Seeker { get; set; }
        public string Remark { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<LocationforBusOPP, GetprocLocationforBusOPPLoadAllVm>();
        }
    }
}
