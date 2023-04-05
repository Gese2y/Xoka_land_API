 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procRenewInfo.procRenewInfoDelete.procRenewInfoDeleteCommand
{

    // @author  Shimels Alem  proc_Renew_InfoDelete stored procedure.

    public class procRenewInfoDeleteCommand : IRequest<IList<RenewInfo_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 