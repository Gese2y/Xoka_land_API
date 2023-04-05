 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procRenewInfoChange.procRenewInfoChangeDelete.procRenewInfoChangeDeleteCommand
{

    // @author  Shimels Alem  proc_Renew_Info_ChangeDelete stored procedure.

    public class procRenewInfoChangeDeleteCommand : IRequest<IList<RenewInfoChange_ChangeID>>
    {
        public System.Guid Change_ID { get; set; }
    }
		
     
		
		 
}
 
 