using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.UnEmployment;

namespace Application.UnEmployment.Quiries.procunEmployeeRequest
{
    public class GetprocunEmployeeRequestLoadAllVm : IMapFrom<unEmployeeRequest>
    {
		public System.Guid Id { get; set; }
		public string TIN { get; set; }
		public string Vital_ID { get; set; }
		public string Full_Name { get; set; }
		public string Type { get; set; }
		public byte[] Photo { get; set; }
		public string Region { get; set; }
		public string Zone { get; set; }
		public string Woreda { get; set; }
		public string kebele { get; set; }
		public string House_Number { get; set; }
		public string Mobile_No { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public byte[] Date_log { get; set; }
		public System.Guid? Licence_Service_Id { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<unEmployeeRequest, GetprocunEmployeeRequestLoadAllVm>();
        }
    }
}
