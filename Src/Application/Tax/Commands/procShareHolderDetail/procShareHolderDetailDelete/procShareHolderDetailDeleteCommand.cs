 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Commands.procShareHolderDetail.procShareHolderDetailDelete.procShareHolderDetailDeleteCommand
{

    // @author  Shimels Alem  proc_Share_Holder_DetailDelete stored procedure.

    public class procShareHolderDetailDeleteCommand : IRequest<IList<ShareHolderDetail_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 