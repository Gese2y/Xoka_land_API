 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procTemporaryTradeName.procTemporaryTradeNameDelete.procTemporaryTradeNameDeleteCommand
{

    // @author  Shimels Alem  proc_Temporary_Trade_NameDelete stored procedure.

    public class procTemporaryTradeNameDeleteCommand : IRequest<IList<TemporaryTradeName_TempNameID>>
    {
        public System.Guid Temp_Name_ID { get; set; }
    }
		
     
		
		 
}
 
 