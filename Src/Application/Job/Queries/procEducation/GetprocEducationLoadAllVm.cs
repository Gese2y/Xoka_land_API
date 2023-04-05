using Application.Common.Mappings;
using AutoMapper;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procEducation
{
    public class GetprocEducationLoadAllVm : IMapFrom<Education>
    {
        public System.Guid ID { get; set; }
        public string EMP_TIN { get; set; }
        public string Level { get; set; }
        public string Instiutution { get; set; }
        public System.DateTime? Graduate_Date { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public System.Guid? Created_By { get; set; }
        public System.Guid? Updated_By { get; set; }
        public System.Byte[]? Date_log { get; set; }
        public string Eduction_Types { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Education, GetprocEducationLoadAllVm>();
        }
        
    }
}
