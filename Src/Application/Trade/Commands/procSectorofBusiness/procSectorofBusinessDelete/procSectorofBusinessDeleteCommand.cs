 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procSectorofBusiness.procSectorofBusinessDelete.procSectorofBusinessDeleteCommand
{

    // @author  Shimels Alem  proc_Sector_of_BusinessDelete stored procedure.

    public class procSectorofBusinessDeleteCommand : IRequest<IList<SectorofBusiness_TINAndCode>>
    {
        public string TIN { get; set; }
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 