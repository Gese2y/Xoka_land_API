using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Quiries.procRenewInfo
{
    public class GetprocRenewInfoLoadAllVm : IMapFrom<RenewInfo>
    {
        public System.Guid ID { get; set; }
        public string TINCOM_REG_Number { get; set; }
        public System.DateTime? Date_EN { get; set; }
        public string Status { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<RenewInfo, GetprocRenewInfoLoadAllVm>();
        }
    }
}
