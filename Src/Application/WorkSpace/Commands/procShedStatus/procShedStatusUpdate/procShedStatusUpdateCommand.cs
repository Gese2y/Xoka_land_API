using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Spatial;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Commands.procShedStatus.procShedStatusUpdate.procShedStatusUpdateCommand
{

    /// @author  Shimels Alem  proc_Shed_StatusUpdate stored procedure.

    public class procShedStatusUpdateCommand : IRequest<IList<ShedStatus_ID>>
   {
        public System.Guid ID { get; set; }
        public byte[] Stutus { get; set; }
        public Geography Construction_Place { get; set; }
        public System.Decimal? Cost { get; set; }
        public string Contactor { get; set; }
    }
		
		
		 
}

