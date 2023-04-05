using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Quiries.procCommercialRegistration
{
    public class GetprocCommercialRegistrationLoadAllVm : IMapFrom<CommercialRegistration>
    {
        public string COM_REG_Number { get; set; }
        public string TIN { get; set; }
        public System.Guid? Temp_Name_ID { get; set; }
        public string Rgistration__Name_AM { get; set; }
        public string Rgistration__Name_EN { get; set; }
        public System.DateTime? Rgistration_Date_EN { get; set; }
        public System.DateTime? Rgistration_Date_AM { get; set; }
        public bool? IS_GM { get; set; }
        public System.DateTime? modified_Date { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CommercialRegistration, GetprocCommercialRegistrationLoadAllVm>();
        }
    }
}
