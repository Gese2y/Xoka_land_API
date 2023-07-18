using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.ProcgetJobMatchwhenitPicktransaction
{
    public class JobMatchwhenitPicktransactionLoadAllVm : IMapFrom<getJobMatchwhenitPicktransaction>
    {
        public System.Guid? Transaction_ID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<getJobMatchwhenitPicktransaction, JobMatchwhenitPicktransactionLoadAllVm>();
        }
    }
}
