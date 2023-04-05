


using MediatR;
using System.Collections.Generic;
using System.Spatial;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Commands.procSheds.procShedsInsert.procShedsInsertCommand
{

    /// @author  Shimels Alem  proc_ShedsInsert stored procedure.


    public class procShedsInsertCommand : IRequest<IList<Sheds_ID>>
    {
        public System.Guid ID { get; set; }
        public Geography? GEO_Location { get; set; }
        public string Type { get; set; }
        public int? Size { get; set; }
        public byte[] Pic { get; set; }
    }
		
		
		 
}
 
 