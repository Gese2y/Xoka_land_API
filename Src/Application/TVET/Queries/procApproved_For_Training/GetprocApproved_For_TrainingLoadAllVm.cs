using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Quiries.procApproved_For_Training
{
    public class GetprocApproved_For_TrainingLoadAllVm : IMapFrom<GetprocApproved_For_TrainingLoadAllVm>
    {
        public System.Guid ID { get; set; }
        public string Vital_ID { get; set; }
        public bool? Approved_for_Training { get; set; }
        public System.DateTime? Date_Applyed { get; set; }
        public System.DateTime? End_Date { get; set; }
        public System.Guid? Approved_By { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Approved_For_Training, GetprocApproved_For_TrainingLoadAllVm>();
        }
    }
}
