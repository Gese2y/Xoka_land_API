using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procEnrollment
{
    public class GetprocEnrollmentLoadAllVm : IMapFrom<Enrollment>
    {
        public System.Guid EID { get; set; }
        public string Code { get; set; }
        public string Batch_ID { get; set; }
        public System.Guid? Student_ID { get; set; }
        public string Status { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Enrollment, GetprocEnrollmentLoadAllVm>();
        }
    }
}
