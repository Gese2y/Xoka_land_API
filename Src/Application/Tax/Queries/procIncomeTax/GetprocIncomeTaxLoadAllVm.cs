using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Quiries.procIncomeTax
{
    public class GetprocIncomeTaxLoadAllVm : IMapFrom<IncomeTax>
    {
        public System.Guid ID { get; set; }
        public System.Guid TIN { get; set; }
        public System.DateTime Year { get; set; }
        public System.DateTime? Date_Paid { get; set; }
        public string Type_Income_Tax { get; set; }
        public int? Amount { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<IncomeTax, GetprocIncomeTaxLoadAllVm>();
        }
    }
}
