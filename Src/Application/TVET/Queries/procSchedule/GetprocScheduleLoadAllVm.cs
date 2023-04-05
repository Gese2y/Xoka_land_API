using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procSchedule
{
    public class GetprocScheduleLoadAllVm : IMapFrom<Schedule>
    {
        public System.Guid SID { get; set; }
        public System.Guid? EID { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
        public System.TimeSpan? Start_Hour { get; set; }
        public System.TimeSpan? End_Hour { get; set; }
        public string Course_Code { get; set; }
        public System.Guid? Instructor_ID { get; set; }
        public string Venue { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Schedule, GetprocScheduleLoadAllVm>();
        }
    }
}
