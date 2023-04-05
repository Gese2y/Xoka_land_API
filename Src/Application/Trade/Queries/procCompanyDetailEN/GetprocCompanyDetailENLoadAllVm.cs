using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Quiries.procCompanyDetailEN
{
    public class GetprocCompanyDetailENLoadAllVm : IMapFrom<CompanyDetailEN>
    {
		public System.Guid ID { get; set; }
		public string COM_REG_Number { get; set; }
		public string Nationality { get; set; }
		public string GM_User { get; set; }
		public System.Guid? Region { get; set; }
		public System.Guid? Zone { get; set; }
		public string City { get; set; }
		public System.Guid? Sub_City { get; set; }
		public System.Guid? Woreda { get; set; }
		public string House_Number { get; set; }
		public string Email { get; set; }
		public bool? Is_Active { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<CompanyDetailEN, GetprocCompanyDetailENLoadAllVm>();
        }
    }
}
