 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procCommercialRegistration.procCommercialRegistrationDelete.procCommercialRegistrationDeleteCommand
{

    // @author  Shimels Alem  proc_Commercial_RegistrationDelete stored procedure.

    public class procCommercialRegistrationDeleteCommand : IRequest<IList<CommercialRegistration_COMREGNumber>>
    {
        public string COM_REG_Number { get; set; }
    }
		
     
		
		 
}
 
 