using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Quiries.procCapitalContract
{
    public class GetprocCapitalContractLoadAllVm : IMapFrom<CapitalContract>
    {
		public System.Guid Contract_ID { get; set; }
		public System.Guid? Application_for_G_ID { get; set; }
		public string NSE_TIN { get; set; }
		public string Contract_Title { get; set; }
		public string Contract_NO { get; set; }
		public System.Guid? Organization_ID { get; set; }
		public System.Double? Total_Contract_Amount { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public System.Guid? Doc_ID { get; set; }
		public bool? Is_Active { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<CapitalContract, GetprocCapitalContractLoadAllVm>();
        }
    }
}
