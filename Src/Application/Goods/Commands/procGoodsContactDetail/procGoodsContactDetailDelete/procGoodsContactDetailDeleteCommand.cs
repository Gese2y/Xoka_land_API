 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Goods;

namespace Application.Goods.Commands.procGoodsContactDetail.procGoodsContactDetailDelete.procGoodsContactDetailDeleteCommand
{

    // @author  Shimels Alem  proc_Goods_Contact_DetailDelete stored procedure.

    public class procGoodsContactDetailDeleteCommand : IRequest<IList<GoodsContactDetail_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 