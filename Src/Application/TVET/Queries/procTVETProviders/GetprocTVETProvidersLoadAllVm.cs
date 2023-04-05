using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procTVETProviders
{
    public class GetprocTVETProvidersLoadAllVm : IMapFrom<TVETProviders>
    {
        public string ProviderCode { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public int? Capacity { get; set; }
        public bool? IS_Active { get; set; }
        public System.Guid? Org_Code { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TVETProviders, GetprocTVETProvidersLoadAllVm>();
        }
    }
}
