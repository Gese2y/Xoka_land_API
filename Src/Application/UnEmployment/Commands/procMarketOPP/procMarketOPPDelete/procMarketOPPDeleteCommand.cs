 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.UnEmployment;

namespace Application.UnEmployment.Commands.procMarketOPP.procMarketOPPDelete.procMarketOPPDeleteCommand
{

    // @author  Shimels Alem  proc_Market_OPPDelete stored procedure.

    public class procMarketOPPDeleteCommand : IRequest<IList<MarketOPP_OPPID>>
    {
        public System.Guid OPP_ID { get; set; }
    }
		
     
		
		 
}
 
 