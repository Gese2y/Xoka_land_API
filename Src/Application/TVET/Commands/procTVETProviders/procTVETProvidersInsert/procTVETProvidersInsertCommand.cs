


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procTVETProviders.procTVETProvidersInsert.procTVETProvidersInsertCommand
{

    /// @author  Shimels Alem  proc_TVET_ProvidersInsert stored procedure.


    public class procTVETProvidersInsertCommand : IRequest<IList<TVETProviders_ProviderCode>>
    {
        public string ProviderCode { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public int? Capacity { get; set; }
        public bool? IS_Active { get; set; }
        public System.Guid? Org_Code { get; set; }
    }
		
		
		 
}
 
 