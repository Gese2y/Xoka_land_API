using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procEmploymentExperience
{
    public class GetprocEmploymentExperienceLoadAllVm : IMapFrom<EmploymentExperience>
    {
		public System.Guid ID { get; set; }
		public string EMP_TIN { get; set; }
		public string EMP_Pension_NO { get; set; }
		public string Types_of_employment { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public System.Double? basic_Salary { get; set; }
		public string Reference { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.Byte[]? Date_log { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<EmploymentExperience, GetprocEmploymentExperienceLoadAllVm>();
        }
    }
}
