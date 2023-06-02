using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procJob_Opportunity
{
    public class GetprocJob_OpportunityLoadAllVm : IMapFrom<Job_Opportunity>
    {
        public System.Guid Job_Opportunity_ID { get; set; }
        public string Stakeholder_TIN { get; set; }
        public string Job_Position { get; set; }
        public string Educ_Operand { get; set; }
        public string Educational_Level_ID { get; set; }
        public string Work_Exp_Operand { get; set; }
        public Nullable<double> Work_Experience_In_Years { get; set; }
        public string Gender_Criteria { get; set; }
        public string Description { get; set; }
        public string Type_Of_Hire { get; set; }
        public Nullable<System.DateTime> Date_Posted { get; set; }
        public Nullable<System.DateTime> Date_Expires { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public string Remarks { get; set; }
        public string Education_Type { get; set; }
        public string Sector { get; set; }
        public string Sub_Sector { get; set; }
        public string Field_of_Business { get; set; }
        public Nullable<System.DateTime> Date_of_sending_to_the_employer_office { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Job_Opportunity, GetprocJob_OpportunityLoadAllVm>();
        }
    }
}
