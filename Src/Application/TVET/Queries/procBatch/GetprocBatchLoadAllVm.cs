using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procBatch
{
    public class GetprocBatchLoadAllVm : IMapFrom<Batch>
    {
        public string Code { get; set; }
        public string provider_Code { get; set; }
        public string Program_Code { get; set; }
        public int Year { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
        public bool? is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Batch, GetprocBatchLoadAllVm>();
        }
    }
}
