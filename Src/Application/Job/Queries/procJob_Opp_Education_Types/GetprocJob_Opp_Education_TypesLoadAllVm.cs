using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procJob_Opp_Education_Types
{
    public class GetprocJob_Opp_Education_TypesLoadAllVm : IMapFrom<Job_Opp_Education_Types>
    {
        public System.Guid Job_Opportunity_ID { get; set; }
        public string Job_Education_Type_ID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Job_Opp_Education_Types, GetprocJob_Opp_Education_TypesLoadAllVm>();
        }
    }
}
