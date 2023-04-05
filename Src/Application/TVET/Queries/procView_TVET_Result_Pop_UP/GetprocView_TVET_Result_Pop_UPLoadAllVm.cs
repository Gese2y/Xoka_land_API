using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procView_TVET_Result_Pop_UP
{
    public class GetprocView_TVET_Result_Pop_UPLoadAllVm : IMapFrom<View_TVET_Result_Pop_UP>
    {
        public Guid ID { get; set; }
        public string Student_Code { get; set; }
        public string Student_Name { get; set; }
        public string   Lname { get; set; }
        public string Mname { get; set; }
        public string Course_Name { get; set; }
        public int Credit_Hour { get; set; }
        public string Provider { get; set; }
        public string Venue { get; set; }
        public string Course_Code{ get; set; }
        public Guid EID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<View_TVET_Result_Pop_UP, GetprocView_TVET_Result_Pop_UPLoadAllVm>();
        }
    }
}
