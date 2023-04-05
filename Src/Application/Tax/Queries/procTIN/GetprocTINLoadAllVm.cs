using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Quiries.procTIN
{
    public class GetprocTINLoadAllVm : IMapFrom<_TIN>
    {
		public System.Guid ID { get; set; }
		public string TIN { get; set; }
		public System.DateTime? Date_Issued { get; set; }
		public string Certificate_Code { get; set; }
		public string Certificate_NO { get; set; }
		public string Remark { get; set; }
		public bool? IsActive { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public byte[] Date_log { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<_TIN, GetprocTINLoadAllVm>();
        }
    }
}
