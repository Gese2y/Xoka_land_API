using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Quiries.procOwnerInfo
{
    public class GetprocOwnerInfoLoadAllVm : IMapFrom<OwnerInfo>
    {
		public System.Guid ID { get; set; }
		public string Position { get; set; }
		public string Full_Name { get; set; }
		public bool? IsActive { get; set; }
		public bool? IS_GM { get; set; }
		public System.DateTime? Registration_Date { get; set; }
		public byte[] Photo { get; set; }
		public string Company_TIn_NO { get; set; }
		public int? NO_Of_Share { get; set; }
		public int? Share_Price { get; set; }
		public bool? IS_Current { get; set; }
		public System.DateTime? YEAR { get; set; }
		public System.Guid? Parent { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<OwnerInfo, GetprocOwnerInfoLoadAllVm>();
        }
    }
}
