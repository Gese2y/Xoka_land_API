 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procOwnerInfo.procOwnerInfoDelete.procOwnerInfoDeleteCommand
{

    // @author  Shimels Alem  proc_Owner_InfoDelete stored procedure.

    public class procOwnerInfoDeleteCommand : IRequest<IList<OwnerInfo_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 