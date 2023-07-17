using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procJob_Match
{
    public class GetprocJob_MatchLoadAllVm : IMapFrom<Job_Match>
    {
        public System.Guid Job_Match_ID { get; set; }
        public Nullable<System.Guid> Transaction_ID { get; set; }
        public string Kebele_ID { get; set; }
        public string Officer_Proposed_Kebele_ID { get; set; }
        public string Officer_Justification { get; set; }
        public Nullable<System.DateTime> Date_Proposed { get; set; }
        public Nullable<bool> Is_Approved { get; set; }
        public string Approval_Justification_Doc { get; set; }
        public string Hired_Justification_Doc { get; set; }
        public Nullable<bool> Is_Hired { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> approved_by_sub_city { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Job_Match, GetprocJob_MatchLoadAllVm>();
        }
    }
}
