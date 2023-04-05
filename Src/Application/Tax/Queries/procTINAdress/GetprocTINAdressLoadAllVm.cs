using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Quiries.procTINAdress
{
    public class GetprocTINAdressLoadAllVm : IMapFrom<TINAdress>
    {
        public System.Guid ID { get; set; }
        public string TIN { get; set; }
        public System.Guid Region { get; set; }
        public System.Guid Zone { get; set; }
        public System.Guid Woreda { get; set; }
        public string kebele { get; set; }
        public string House_Number { get; set; }
        public bool? IS_Active { get; set; }
        public System.Guid? Parent { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TINAdress, GetprocTINAdressLoadAllVm>();
        }
    }
}
