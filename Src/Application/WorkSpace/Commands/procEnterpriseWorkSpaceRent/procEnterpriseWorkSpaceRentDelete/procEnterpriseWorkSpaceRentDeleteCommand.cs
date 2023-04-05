 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Commands.procEnterpriseWorkSpaceRent.procEnterpriseWorkSpaceRentDelete.procEnterpriseWorkSpaceRentDeleteCommand
{

    // @author  Shimels Alem  proc_Enterprise_Work_Space_RentDelete stored procedure.

    public class procEnterpriseWorkSpaceRentDeleteCommand : IRequest<IList<EnterpriseWorkSpaceRent_WorkSpaceIDAndTIN>>
    {
        public System.Guid Work_Space_ID { get; set; }
        public string TIN { get; set; }
    }
		
     
		
		 
}
 
 