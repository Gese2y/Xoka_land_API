using Application.Common.Mappings;
using AutoMapper;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Quiries.procApplicationForCreadit
{
    public class GetprocApplicationForCreaditLoadAllVm : IMapFrom<ApplicationForCreadit>
    {
        public System.Guid ID { get; set; }
        public long? TIN { get; set; }
        public string Application { get; set; }
        public System.Double? Amount { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public bool? IS_Disprove { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ApplicationForCreadit, GetprocApplicationForCreaditLoadAllVm>();
        }
    }
}
