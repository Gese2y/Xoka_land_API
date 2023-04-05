 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Commands.procShareHolderOrMSE.procShareHolderOrMSEDelete.procShareHolderOrMSEDeleteCommand
{

    // @author  Shimels Alem  [proc_Share_Holder(MSE)Delete] stored procedure.

    public class procShareHolderOrMSEDeleteCommand : IRequest<IList<ShareHolderOrMSE_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 