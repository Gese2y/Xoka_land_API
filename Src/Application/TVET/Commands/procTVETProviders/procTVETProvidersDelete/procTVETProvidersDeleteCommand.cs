 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procTVETProviders.procTVETProvidersDelete.procTVETProvidersDeleteCommand
{

    // @author  Shimels Alem  proc_TVET_ProvidersDelete stored procedure.

    public class procTVETProvidersDeleteCommand : IRequest<IList<TVETProviders_ProviderCode>>
    {
        public string ProviderCode { get; set; }
    }
		
     
		
		 
}
 
 