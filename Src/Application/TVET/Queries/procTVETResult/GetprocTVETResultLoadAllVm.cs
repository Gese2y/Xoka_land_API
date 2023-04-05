using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procTVETResult
{
    public class GetprocTVETResultLoadAllVm : IMapFrom<TVETResult>
    {
        public System.Guid RId { get; set; }
        public System.Guid? EID { get; set; }
        public System.Guid? Student_ID { get; set; }
        public string Total_Result { get; set; }
        public string Remark { get; set; }
        public bool? IsPass { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TVETResult, GetprocTVETResultLoadAllVm>();
        }
    }
}
