using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procMSEwarning
{
    public class GetprocMSEwarningLoadAllVm : IMapFrom<MSEwarning>
    {
        public System.Guid ID { get; set; }
        public string TIN { get; set; }
        public string Warning_Code { get; set; }
        public System.DateTime? Date_Issued { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public byte[] Warning_Letter_Doc { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<MSEwarning, GetprocMSEwarningLoadAllVm>();
        }
    }
}
