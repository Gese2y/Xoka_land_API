using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procProgramAndCourse
{
    public class GetprocProgramAndCourseLoadAllVm : IMapFrom<ProgramAndCourse>
    {
        public System.Guid P_C_ID { get; set; }
        public string Program_code { get; set; }
        public string Course_ID { get; set; }
        public bool? IS_Active { get; set; }
        public string Remarks { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ProgramAndCourse, GetprocProgramAndCourseLoadAllVm>();
        }
    }
}
