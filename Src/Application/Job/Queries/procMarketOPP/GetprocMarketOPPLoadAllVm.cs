using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procMarketOPP
{
    public class GetprocMarketOPPLoadAllVm : IMapFrom<MarketOPP>
    {
        public System.Guid OPP_ID { get; set; }
        public string TIN { get; set; }
        public string Opp_Type { get; set; }
        public Nullable<System.Guid> Region { get; set; }
        public Nullable<System.Guid> Zone { get; set; }
        public Nullable<System.Guid> Woreda { get; set; }
        public string Hous_No { get; set; }
        public Nullable<int> JobOpen_For_ENT { get; set; }
        public Nullable<int> Job_Open_For_Job_Seeker { get; set; }
        public Nullable<System.Guid> Licence_ID { get; set; }
        public Nullable<System.DateTime> Registered_Date { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<MarketOPP, GetprocMarketOPPLoadAllVm>();
        }
    }
}
