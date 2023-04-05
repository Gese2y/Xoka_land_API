using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procProduct
{
    public class GetprocProductLoadAllVm : IMapFrom<Product>
    {
        public System.Guid ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Sector { get; set; }
        public string Sub_Sector { get; set; }
        public System.Guid? Parent { get; set; }
        public bool? IS_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, GetprocProductLoadAllVm>();
        }
    }
}
