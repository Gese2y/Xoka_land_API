using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.view;

namespace Application.Vital.Quiries.VitalEventsGetSubcityByWoreda
{
    public class GetVitalEventsGetSubcityByWoredaOrgLoadAllVm : IMapFrom<VitalEventsGetSubcityByWoredaOrg>
    {
        public string ID { get; set; }
        public string RegistrationOrgWoreda { get; set; }
        public string Registration_code { get; set; }
        public string name_en { get; set; }
        public System.Guid organizations_organization_code { get; set; }
        public System.Guid organization_code { get; set; }
        public System.Guid Regstered_Org { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<VitalEventsGetSubcityByWoredaOrg, GetVitalEventsGetSubcityByWoredaOrgLoadAllVm>();
        }
    }
}
