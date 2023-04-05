 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procSector.procSectorDelete.procSectorDeleteCommand
{

    // @author  Shimels Alem  proc_Business_ActivityDelete stored procedure.

    public class procSectorDeleteCommand : IRequest<IList<Sector_Code>>
    {
		public string S_Code { get; set; }
	}
		
     
		
		 
}
 
 