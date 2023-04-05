 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procCapitalContract.procCapitalContractDelete.procCapitalContractDeleteCommand
{

    // @author  Shimels Alem  proc_Capital_ContractDelete stored procedure.

    public class procCapitalContractDeleteCommand : IRequest<IList<CapitalContract_ContractID>>
    {
        public System.Guid Contract_ID { get; set; }
    }
		
     
		
		 
}
 
 