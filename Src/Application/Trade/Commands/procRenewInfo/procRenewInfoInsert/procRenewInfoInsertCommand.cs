


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procRenewInfo.procRenewInfoInsert.procRenewInfoInsertCommand
{

    /// @author  Shimels Alem  proc_Renew_InfoInsert stored procedure.


    public class procRenewInfoInsertCommand : IRequest<IList<RenewInfo_ID>>
    {
        public System.Guid ID { get; set; }
        public string TINCOM_REG_Number { get; set; }
        public System.DateTime? Date_EN { get; set; }
        public string Status { get; set; }
    }
		
		
		 
}
 
 