using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procListofCourse
{
    public class GetprocListofCourseLoadAllVm : IMapFrom<ListofCourse>
    {
        public System.Guid ID { get; set; }
        public string Course_Name { get; set; }
        public string IS_Active { get; set; }
        public System.Guid? TVET_ID { get; set; }
        public string Credit_Hour { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ListofCourse, GetprocListofCourseLoadAllVm>();
        }
    }
}
