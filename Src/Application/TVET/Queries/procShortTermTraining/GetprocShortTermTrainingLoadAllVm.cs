using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procShortTermTraining
{
    public class GetprocShortTermTrainingLoadAllVm : IMapFrom<ShortTermTraining>
    {
        public System.Guid ID { get; set; }
        public string EMP_TIN { get; set; }
        public string Training_Type { get; set; }
        public string Instiutution { get; set; }
        public int? Passmark { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public string Training_Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ShortTermTraining, GetprocShortTermTrainingLoadAllVm>();
        }
    }
}
