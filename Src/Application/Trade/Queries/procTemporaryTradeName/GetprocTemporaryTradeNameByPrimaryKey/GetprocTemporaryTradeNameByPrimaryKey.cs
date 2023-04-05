using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procTemporaryTradeName.GetprocTemporaryTradeNameLoadAll;

namespace Application.Trade.Quiries.procTemporaryTradeName.GetprocTemporaryTradeNameByPrimaryKey
{
    /// @author  Shimels Alem proc_Temporary_Trade_NameLoadByPrimaryKey stored procedure.

    public class GetprocTemporaryTradeNameByPrimaryKey : IRequest<GetprocTemporaryTradeNameLoadAllListVm>
    {
        public System.Guid Temp_Name_ID { get; set; }
    }
}
