using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Quiries.procCapital
{
    public class GetprocCapitalLoadAllVm : IMapFrom<Capital>

    {
        public System.Guid Capital_ID { get; set; }
        public string COM_REG_Number { get; set; }
        public System.Double Intaial_Capital { get; set; }
        public System.Double? Current_Capital { get; set; }
        public string Year { get; set; }
        public System.DateTime? Updated_Date { get; set; }
        public bool? Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Capital, GetprocCapitalLoadAllVm>();
        }
    }
}
