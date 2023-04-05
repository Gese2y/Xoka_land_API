using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Goods;
using XOKA.Domain.Interfaces;

namespace Application.Goods.Commands.procGoodsContactDetail.procGoodsContactDetailUpdate.procGoodsContactDetailUpdateCommand
{

	/// @author  Shimels Alem  proc_Goods_Contact_DetailUpdate stored procedure.

	public class procGoodsContactDetailUpdateCommand : IRequest<IList<GoodsContactDetail_ID>>
   {
        public System.Guid ID { get; set; }
        public System.Guid? Good_Contract_ID { get; set; }
        public string FIXED_Asset_No { get; set; }
        public string Unit { get; set; }
        public System.Int32? QTY { get; set; }
        public System.Double? Unit_Price_Birr { get; set; }
        public System.Double? Total_Price { get; set; }
        public string Remark { get; set; }
    }
		
		
		 
}

