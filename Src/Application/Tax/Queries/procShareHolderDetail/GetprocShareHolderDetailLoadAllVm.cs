using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Quiries.procShareHolderDetail
{
    public class GetprocShareHolderDetailLoadAllVm : IMapFrom<ShareHolderDetail>
    {
		public System.Guid ID { get; set; }
		public string TIN { get; set; }
		public string Shere_Type { get; set; }
		public System.DateTime? Transfer_Date { get; set; }
		public string DAR_NO { get; set; }
		public int? No_Share { get; set; }
		public System.Double? Share_Price { get; set; }
		public int? Total_Share { get; set; }
		public System.Guid? Doc_ID { get; set; }
		public string Full_Name { get; set; }
		public string YEAR { get; set; }
		public System.Guid? Parent { get; set; }
		public bool? IS_Current { get; set; }
		public string Kebele_ID { get; set; }
		public bool Is_Manager { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<ShareHolderDetail, GetprocShareHolderDetailLoadAllVm>();
        }
    }
}
