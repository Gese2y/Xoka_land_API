using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Goods;

namespace Application.Goods.Quiries.procApplicationForCapitalGoods
{
    public class GetprocApplicationForCapitalGoodsLoadAllVm : IMapFrom<ApplicationForCapitalGoods>
    {
        public System.Guid ID { get; set; }
        public System.Guid? Licence_Id { get; set; }
        public long? TIN { get; set; }
        public string Application { get; set; }
        public System.Double? Amount { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public bool? IS_Disprove { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ApplicationForCapitalGoods, GetprocApplicationForCapitalGoodsLoadAllVm>();
        }
    }
}
