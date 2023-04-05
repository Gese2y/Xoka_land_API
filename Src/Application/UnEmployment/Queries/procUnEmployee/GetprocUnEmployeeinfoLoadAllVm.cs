using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.UnEmployment;

namespace Application.UnEmployment.Quiries.procUnEmployee
{
    public class GetprocUnEmployeeinfoLoadAllVm : IMapFrom<UnEmployee>
    {
        public string Vital_ID { get; set; }
        public string TIN { get; set; }
        public string Full_Name { get; set; }
        public string Status { get; set; }
        public System.DateTime? Date_Issued { get; set; }
        public string Physical_Condition { get; set; }
        public string Refugee_Status { get; set; }
        public string HIV_Status { get; set; }
        public string Returnee_Status { get; set; }
        public string Gender { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UnEmployeeinfos, GetprocUnEmployeeinfoLoadAllVm>();
        }
    }
}
