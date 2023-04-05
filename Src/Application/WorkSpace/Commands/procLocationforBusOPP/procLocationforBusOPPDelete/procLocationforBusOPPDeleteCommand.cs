 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Commands.procLocationforBusOPP.procLocationforBusOPPDelete.procLocationforBusOPPDeleteCommand
{

    // @author  Shimels Alem  proc_Location_for_Bus_OPPDelete stored procedure.

    public class procLocationforBusOPPDeleteCommand : IRequest<IList<LocationforBusOPP_BUSOPPLocCode>>
    {
        public System.Guid BUS_OPP_Loc_Code { get; set; }
    }
		
     
		
		 
}
 
 