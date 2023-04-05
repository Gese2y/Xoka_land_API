using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procStudent
{
    public class GetprocStudentLoadAllVm : IMapFrom<Student>
    {
		public System.Guid ID { get; set; }
		public string Code { get; set; }
		public string Type { get; set; }
		public string Fname { get; set; }
		public string Lname { get; set; }
		public string Mame { get; set; }
		public System.DateTime Reg_Date { get; set; }
		public bool? Applicatuion_Submitted { get; set; }
		public bool? Is_Approved { get; set; }
		public System.Guid? Licence_ID { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<Student, GetprocStudentLoadAllVm>();
        }
    }
}
