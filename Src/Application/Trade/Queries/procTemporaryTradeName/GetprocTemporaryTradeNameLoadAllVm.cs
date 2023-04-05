using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Quiries.procTemporaryTradeName
{
    public class GetprocTemporaryTradeNameLoadAllVm : IMapFrom<TemporaryTradeName>
    {
		public System.Guid Temp_Name_ID { get; set; }
		public string Code { get; set; }
		public string Name_EN { get; set; }
		public string Name_AM { get; set; }
		public string Status { get; set; }
		public string Latter_Number { get; set; }
		public System.DateTime? Registration_Date { get; set; }
		public System.DateTime? Expire_Date { get; set; }
		public System.Guid? Parent_Name { get; set; }
		public string Child_Name { get; set; }
		public System.Guid? Licence_ID { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<TemporaryTradeName, GetprocTemporaryTradeNameLoadAllVm>();
        }
    }
}
