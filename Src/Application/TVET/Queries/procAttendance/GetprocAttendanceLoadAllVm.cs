using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procAttendance
{
    public class GetprocAttendanceLoadAllVm : IMapFrom<Attendance>
    {
        public System.Guid ID { get; set; }
        public System.Guid? Schedule_id { get; set; }
        public System.DateTime? Date { get; set; }
        public bool? Is_Present { get; set; }
        public System.Guid? Student_ID { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Attendance, GetprocAttendanceLoadAllVm>();
        }
    }
}
