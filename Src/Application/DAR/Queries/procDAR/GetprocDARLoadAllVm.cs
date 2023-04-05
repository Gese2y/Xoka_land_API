using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.DAR;

namespace Application.DAR.Quiries.procDAR
{
    public class GetprocDARLoadAllVm : IMapFrom<_DAR>
    {
        public string DAR_NO { get; set; }
        public string Name_EN { get; set; }
        public string Name_AM { get; set; }
        public string DAR_Type { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public bool? IS_Signed { get; set; }
        public System.Int32? No_of_Copy { get; set; }
        public string Parent { get; set; }
        public System.Guid? Licence_Id { get; set; }
        public string Remark { get; set; }
        public System.Guid? Temp_Name_ID { get; set; }
        public string Ownership_Type { get; set; }
        public byte[] Scanned_Document { get; set; }
        public System.Int32? Number_Of_Pages { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<_DAR, GetprocDARLoadAllVm>();
        }
       
    }
}
