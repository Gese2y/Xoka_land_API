using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procTVETlistCourse
{
    public class GetprocTVETlistCourseLoadAllVm : IMapFrom<TVETlistCourse>
    {
        public string Code { get; set; }
        public string Course_Name { get; set; }
        public bool? Is_Active { get; set; }
        public byte Credit_Hour { get; set; }
        public string prerequisites_Course { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TVETlistCourse, GetprocTVETlistCourseLoadAllVm>();
        }
    }
}
