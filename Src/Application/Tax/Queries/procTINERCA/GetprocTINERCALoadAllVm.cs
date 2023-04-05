using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Quiries.procTINERCA
{
    public class GetprocTINERCALoadAllVm : IMapFrom<TINERCA>
    {
		public string TIN { get; set; }
		public System.DateTime? Date_Regstered { get; set; }
		public string TIN_Type { get; set; }
		public System.Guid? ORG_ID { get; set; }
		public string Status { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public byte[] Date_log { get; set; }
		public System.Guid? Licence_ID { get; set; }
		public string Company_Name { get; set; }
		public string Tax_Center { get; set; }
		public string DAR_NO { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<TINERCA, GetprocTINERCALoadAllVm>();
        }
    }
}
