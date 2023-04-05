using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Quiries.procEmployeeTINInfo
{
    public class GetprocEmployeeTINInfoLoadAllVm : IMapFrom<EmployeeTINInfo>
    {
		public System.Guid Emp_TIN_ID { get; set; }
		public string TIN { get; set; }
		public System.DateTime? Date_Issued { get; set; }
		public string Certificate_Code { get; set; }
		public string Certificate_NO { get; set; }
		public string First_Name { get; set; }
		public string Last_Name { get; set; }
		public string Middle_Name { get; set; }
		public string Gender { get; set; }
		public System.DateTime? Date_Expired { get; set; }
		public System.DateTime? Date_of_Birth { get; set; }
		public byte[] Finger_Print { get; set; }
		public byte[] Photo { get; set; }
		public string Remark { get; set; }
		public bool? IsActive { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<EmployeeTINInfo, GetprocEmployeeTINInfoLoadAllVm>();
        }
    }
}
