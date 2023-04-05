using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Vital;

namespace Application.Vital.Quiries.procVitalEvents
{
    public class GetprocVitalEventsLoadAllVm : IMapFrom<VitalEvents>
    {
		public string ID { get; set; }
		public System.DateTime? Date_of_Birth { get; set; }
		public string Blood_Group { get; set; }
		public string Gender { get; set; }
		public string Status { get; set; }
		public System.Guid? Regstered_Org { get; set; }
		public System.Guid? User_ID { get; set; }
		public System.DateTime? created_date { get; set; }
		public System.DateTime? Updated_date { get; set; }
		public System.Guid? Updated_By_user { get; set; }
		public System.Guid? Licence_ID { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<VitalEvents, GetprocVitalEventsLoadAllVm>();
        }
    }
}
