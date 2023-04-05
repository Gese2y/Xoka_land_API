 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procBusinessCode.procBusinessCodeDelete.procBusinessCodeDeleteCommand
{

    // @author  Shimels Alem  proc_Business_CodeDelete stored procedure.

    public class procBusinessCodeDeleteCommand : IRequest<IList<BusinessCode_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 