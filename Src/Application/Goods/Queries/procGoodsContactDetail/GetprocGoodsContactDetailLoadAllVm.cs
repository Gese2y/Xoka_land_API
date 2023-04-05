using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Goods;

namespace Application.Goods.Quiries.procGoodsContactDetail
{
    public class GetprocGoodsContactDetailLoadAllVm : IMapFrom<GoodsContactDetail>
    {
        public System.Guid ID { get; set; }
        public System.Guid? Good_Contract_ID { get; set; }
        public string FIXED_Asset_No { get; set; }
        public string Unit { get; set; }
        public System.Int32? QTY { get; set; }
        public System.Double? Unit_Price_Birr { get; set; }
        public System.Double? Total_Price { get; set; }
        public string Remark { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GoodsContactDetail, GetprocGoodsContactDetailLoadAllVm>();
        }
    }
}
