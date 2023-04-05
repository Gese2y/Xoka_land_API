 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Commands.procCollateral.procCollateralDelete.procCollateralDeleteCommand
{

    // @author  Shimels Alem  proc_CollateralDelete stored procedure.

    public class procCollateralDeleteCommand : IRequest<IList<Collateral_CollateralID>>
    {
        public System.Guid Collateral_ID { get; set; }
    }
		
     
		
		 
}
 
 