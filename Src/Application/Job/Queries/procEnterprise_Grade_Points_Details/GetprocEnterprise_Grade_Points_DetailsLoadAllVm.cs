using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procEnterprise_Grade_Points_Details
{
    public class GetprocEnterprise_Grade_Points_DetailsLoadAllVm : IMapFrom<Enterprise_Grade_Points_Details>
    {
        public string ID { get; set; }
        public DateTime Date_Graded { get; set; }
        public string Filled_By { get; set; }
        public string JSON_Value { get; set; }
        public string Enterprise_TIN { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Enterprise_Grade_Points_Details, GetprocEnterprise_Grade_Points_DetailsLoadAllVm>();
        }
    }
}
