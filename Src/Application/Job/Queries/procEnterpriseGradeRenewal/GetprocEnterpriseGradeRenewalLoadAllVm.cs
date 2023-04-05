using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procEnterpriseGradeRenewal
{
    public class GetprocEnterpriseGradeRenewalLoadAllVm : IMapFrom<Enterprise_Grade_Renewal_Details>
    {
        public System.Guid Ent_Grading_Detail_ID { get; set; }
        public string Code { get; set; }
        public string TIN { get; set; }
        public byte[] Grading_Letter { get; set; }
        public Nullable<System.DateTime> Date_Of_Grade_Issued { get; set; }
        public string Remarks { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Enterprise_Grade_Renewal_Details, GetprocEnterpriseGradeRenewalLoadAllVm>();
        }
    }
}
