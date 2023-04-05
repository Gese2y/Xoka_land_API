 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Commands.procInstalments.procInstalmentsDelete.procInstalmentsDeleteCommand
{

    // @author  Shimels Alem  proc_InstalmentsDelete stored procedure.

    public class procInstalmentsDeleteCommand : IRequest<IList<Instalments_contractidAndnumber>>
    {
        public System.Guid contract_id { get; set; }
        public System.Int32 number { get; set; }
    }
		
     
		
		 
}
 
 