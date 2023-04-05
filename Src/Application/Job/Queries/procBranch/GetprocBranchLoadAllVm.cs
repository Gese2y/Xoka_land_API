using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procBranch
{
    public class GetprocBranchLoadAllVm : IMapFrom<Branch>
    {
        public System.Guid ID { get; set; }
        public byte[]? Address { get; set; }
        public string Type { get; set; }
        public string Product { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Branch, GetprocBranchLoadAllVm>();
        }
    }
}
