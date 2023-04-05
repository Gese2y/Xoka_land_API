using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procJob_Assignment_Transaction
{
    public class GetprocJob_Assignment_TransactionLoadAllVm : IMapFrom<Job_Assignment_Transaction>
    {
        public System.Guid Transaction_ID { get; set; }
        public Nullable<System.Guid> Job_Opportunity_ID { get; set; }
        public Nullable<System.Guid> Woreda { get; set; }
        public Nullable<double> Number_Of_Person { get; set; }
        public string Approval_Justification_Doc { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Job_Assignment_Transaction, GetprocJob_Assignment_TransactionLoadAllVm>();
        }
    }
}
