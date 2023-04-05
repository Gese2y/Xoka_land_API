 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procCapital.procCapitalDelete.procCapitalDeleteCommand
{

    // @author  Shimels Alem  proc_CapitalDelete stored procedure.

    public class procCapitalDeleteCommand : IRequest<IList<Capital_CapitalID>>
    {
        public System.Guid Capital_ID { get; set; }
    }
		
     
		
		 
}
 
 