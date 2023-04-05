 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Commands.procIncomeTax.procIncomeTaxDelete.procIncomeTaxDeleteCommand
{

    // @author  Shimels Alem  proc_Income_TaxDelete stored procedure.

    public class procIncomeTaxDeleteCommand : IRequest<IList<IncomeTax_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 