using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Quiries.procCOCCandidate
{
    public class GetprocCOCCandidateLoadAllVm : IMapFrom<COCCandidate>
    {
		public System.Guid COC_Cand_ID { get; set; }
		public string Candidate_Type { get; set; }
		public string First_Name_EN { get; set; }
		public string Middle_Name_EN { get; set; }
		public string Last_Name_EN { get; set; }
		public string First_Name_AM { get; set; }
		public string Middle_Name_AM { get; set; }
		public string Last_Name_AM { get; set; }
		public string Program { get; set; }
		public string Enrolment_ID { get; set; }
		public System.DateTime? Registration_Date { get; set; }
		public bool? IS_APP_Submitted { get; set; }
		public System.Guid? Doc_Id { get; set; }
		public System.Guid? Licence_ID { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<COCCandidate, GetprocCOCCandidateLoadAllVm>();
        }
    }
}
