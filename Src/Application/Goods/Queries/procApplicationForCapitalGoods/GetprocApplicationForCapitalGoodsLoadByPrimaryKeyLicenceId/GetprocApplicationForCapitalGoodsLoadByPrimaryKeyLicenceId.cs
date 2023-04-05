using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Goods.Quiries.procApplicationForCapitalGoods.GetprocApplicationForCapitalGoodsLoadAll;

namespace Application.Goods.Quiries.procApplicationForCapitalGoods.procApplicationForCapitalGoodsLoadByPrimaryKeyLicenceId
{
    /// @author  Shimels Alem proc_Application_For_Capital_GoodsLoadByPrimaryKey_Licence_Id stored procedure.

    public class procApplicationForCapitalGoodsLoadByPrimaryKeyLicenceId : IRequest<GetprocApplicationForCapitalGoodsLoadAllListVm>
    {
        public System.Guid Licence_Id { get; set; }
    }
}
