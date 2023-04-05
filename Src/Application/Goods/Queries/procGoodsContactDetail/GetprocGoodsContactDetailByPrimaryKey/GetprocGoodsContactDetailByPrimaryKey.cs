using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Goods.Quiries.procGoodsContactDetail.GetprocGoodsContactDetailLoadAll;

namespace Application.Goods.Quiries.procGoodsContactDetail.GetprocGoodsContactDetailByPrimaryKey
{
    /// @author  Shimels Alem proc_Goods_Contact_DetailLoadByPrimaryKey stored procedure.

    public class GetprocGoodsContactDetailByPrimaryKey : IRequest<GetprocGoodsContactDetailLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
