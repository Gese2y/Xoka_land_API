 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procBusinessActivity.procBusinessActivityDelete.procBusinessActivityDeleteCommand
{

    // @author  Shimels Alem  proc_Business_ActivityDelete stored procedure.

    public class procBusinessActivityDeleteCommand : IRequest<IList<BusinessActivity_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 