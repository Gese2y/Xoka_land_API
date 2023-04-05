using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Vital;

namespace Application.Vital.Quiries.procvitallog
{
    public class GetprocvitallogLoadAllVm : IMapFrom<vitallog>
    {
		public string Kebele_ID { get; set; }
		public string Description { get; set; }
		public System.DateTime? ExcutionDate { get; set; }
		
		public void Mapping(Profile profile)
        {
            profile.CreateMap<vitallog, GetprocvitallogLoadAllVm>();
        }
    }
}
