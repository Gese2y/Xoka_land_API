


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procSectorofBusiness.procSectorofBusinessInsert.procSectorofBusinessInsertCommand
{

    /// @author  Shimels Alem  proc_Sector_of_BusinessInsert stored procedure.


    public class procSectorofBusinessInsertCommand : IRequest<IList<SectorofBusiness_TINAndCode>>
    {
        public string TIN { get; set; }
        public string Code { get; set; }
        public bool? Is_Active { get; set; }
    }
		
		
		 
}
 
 