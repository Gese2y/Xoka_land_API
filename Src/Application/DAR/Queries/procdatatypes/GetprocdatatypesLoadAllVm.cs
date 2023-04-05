using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.DAR;

namespace Application.DAR.Quiries.procdatatypes
{
    public class GetprocdatatypesLoadAllVm : IMapFrom<_DAR>
    {
        public System.Guid data_type_code { get; set; }
        public int? data_type { get; set; }
        public string data_type_name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<datatypes, GetprocdatatypesLoadAllVm>();
        }
    }
}
