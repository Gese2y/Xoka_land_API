


using MediatR;
using System.Collections.Generic;
using System.Spatial;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Commands.procShedStatus.procShedStatusInsert.procShedStatusInsertCommand
{

    /// @author  Shimels Alem  proc_Shed_StatusInsert stored procedure.


    public class procShedStatusInsertCommand : IRequest<IList<ShedStatus_ID>>
    {
        public System.Guid ID { get; set; }
        public byte[] Stutus { get; set; }
        public Geography Construction_Place { get; set; }
        public System.Decimal? Cost { get; set; }
        public string Contactor { get; set; }
    }
		
		
		 
}
 
 