using Application.Common.Mappings;
using AutoMapper;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Quiries.procShareHolderOrMSE
{
    public class GetprocShareHolderOrMSELoadAllVm : IMapFrom<ShareHolderOrMSE>
    {
        public System.Guid ID { get; set; }
        public string MSE_TIN { get; set; }
        public string Share_Holder_TIN { get; set; }
        public string MSE_Share_Holder_Status { get; set; }
        public bool? IS_Active { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ShareHolderOrMSE, GetprocShareHolderOrMSELoadAllVm>();
        }
    }
}
