using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Goods.Quiries.procApplicationForCapitalGoods.GetprocApplicationForCapitalGoodsLoadAll;

namespace Application.Goods.Quiries.procApplicationForCapitalGoods.GetprocApplicationForCapitalGoodsByPrimaryKey
{
    /// @author  Shimels Alem proc_Application_For_Capital_GoodsLoadByPrimaryKey stored procedure.

    public class GetprocApplicationForCapitalGoodsByPrimaryKey : IRequest<GetprocApplicationForCapitalGoodsLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
