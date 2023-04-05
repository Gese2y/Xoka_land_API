 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Commands.procTINAdress.procTINAdressDelete.procTINAdressDeleteCommand
{

    // @author  Shimels Alem  proc_TIN_AdressDelete stored procedure.

    public class procTINAdressDeleteCommand : IRequest<IList<TINAdress_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 