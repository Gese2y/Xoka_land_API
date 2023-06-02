using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procJob_Position
{
    public class GetprocJob_PositionLoadAllVm : IMapFrom<Job_Position>
    {
        public string Job_Position_ID { get; set; }
        public string Position_Name { get; set; }
        public string Parent_ID { get; set; }
        public string Sector { get; set; }
        public string Sub_Sector { get; set; }
        public string Field_of_Bussines { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Job_Position, GetprocJob_PositionLoadAllVm>();
        }
    }
}
