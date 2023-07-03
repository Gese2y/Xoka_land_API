using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procSub_City_Job_Assignment_Transaction
{
    public class GetprocSub_City_Job_Assignment_TransactionLoadAllVm : IMapFrom<Sub_City_Job_Assignment_Transaction>
    {
        public System.Guid Transaction_ID { get; set; }
        public Nullable<System.Guid> Job_Opportunity_ID { get; set; }
        public Nullable<System.Guid> Sub_City { get; set; }
        public Nullable<double> Number_Of_Person { get; set; }
        public string Approval_Justification_Doc { get; set; }
        public string Created_By { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Sub_City_Job_Assignment_Transaction, GetprocSub_City_Job_Assignment_TransactionLoadAllVm>();
        }
    }
}
