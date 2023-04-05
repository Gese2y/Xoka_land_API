 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Commands.procSavingContract.procSavingContractDelete.procSavingContractDeleteCommand
{

    // @author  Shimels Alem  proc_Saving_ContractDelete stored procedure.

    public class procSavingContractDeleteCommand : IRequest<IList<SavingContract_contractid>>
    {
        public System.Guid contract_id { get; set; }
    }
		
     
		
		 
}
 
 