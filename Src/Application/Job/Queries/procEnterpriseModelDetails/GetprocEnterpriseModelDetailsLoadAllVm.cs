using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procEnterpriseModelDetails
{
    public class GetprocEnterpriseModelDetailsLoadAllVm : IMapFrom<Enterprise_Model_Details>
    {
        public System.Guid Ent_Model_Detail_ID { get; set; }
        public string TIN { get; set; }
        public byte[] Model_Evaluation_Letter { get; set; }
        public Nullable<System.DateTime> Date_Of_Model_Selection { get; set; }
        public Nullable<double> Point_Earned { get; set; }
        public string Remarks { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Enterprise_Model_Details, GetprocEnterpriseModelDetailsLoadAllVm>();
        }
    }
}
