 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Goods;

namespace Application.Goods.Commands.procApplicationForCapitalGoods.procApplicationForCapitalGoodsDelete.procApplicationForCapitalGoodsDeleteCommand
{

    // @author  Shimels Alem  proc_Application_For_Capital_GoodsDelete stored procedure.

    public class procApplicationForCapitalGoodsDeleteCommand : IRequest<IList<ApplicationForCapitalGoods_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 