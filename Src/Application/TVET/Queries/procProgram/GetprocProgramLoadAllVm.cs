using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procProgram
{
    public class GetprocProgramLoadAllVm : IMapFrom<Program>
    {
        public string Program_Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Level { get; set; }
        public int? Period_In_Day { get; set; }
        public string Program_Major { get; set; }
        public System.Double? MIN_Total_Credit { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Program, GetprocProgramLoadAllVm>();
        }
    }
}
