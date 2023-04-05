using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Quiries.procOCACExamCandidate
{
    public class GetprocOCACExamCandidateLoadAllVm : IMapFrom<OCACExamCandidate>
    {
        public System.Guid OCAC_Candiate { get; set; }
        public System.Guid? OCAC_Exam_Plan_ID { get; set; }
        public System.Guid? Cand_ID { get; set; }
        public byte[]? IS_Approved { get; set; }
        public string IS_Present { get; set; }
        public string Remark { get; set; }
        public string Student { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<OCACExamCandidate, GetprocOCACExamCandidateLoadAllVm>();
        }
    }
}
