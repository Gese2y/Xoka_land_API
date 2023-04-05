using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Quiries.procOCACExamPlan
{
    public class GetprocOCACExamPlanLoadAllVm : IMapFrom<OCACExamPlan>
    {
		public System.Guid OCAC_Exam_Plan_ID { get; set; }
		public System.Guid? Application_code { get; set; }
		public System.Guid? Orgnization_Code { get; set; }
		public string Centor_Code { get; set; }
		public string OS_Code { get; set; }
		public string Exam_Code { get; set; }
		public System.DateTime? Year { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public System.TimeSpan? Start_Hour { get; set; }
		public System.TimeSpan End_Hour { get; set; }
		public string Venue { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<OCACExamPlan, GetprocOCACExamPlanLoadAllVm>();
        }
    }
}
