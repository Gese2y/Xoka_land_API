using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Quiries.procExamCentor
{
    public class GetprocExamCentorLoadAllVm : IMapFrom<ExamCentor>
    {
        public string Centor_Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public System.Guid Org_Code { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ExamCentor, GetprocExamCentorLoadAllVm>();
        }
    }
}
