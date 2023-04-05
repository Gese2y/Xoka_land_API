using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procEnterpriseRegistration
{
    public class View_Sector_Sub_Sector_Field_Of_Business : IMapFrom<View_Sector_Sub_Sector_Field_Of_Businessent>
    {
		public string TIN { get; set; }
		public string Name_Of_Enterprise { get; set; }
		public string Field_Of_Business_Code { get; set; }
		public string Field_of_Business { get; set; }
		public string Sub_Sector { get; set; }
		public string Sector { get; set; }
		public string Sub_Sector_Code { get; set; }
		public string Sector_Code { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<View_Sector_Sub_Sector_Field_Of_Businessent, View_Sector_Sub_Sector_Field_Of_Business>();
        }
    }
}
