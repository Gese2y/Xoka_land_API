using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procTVETProviders.GetprocTVETProvidersLoadAll;

namespace Application.TVET.Quiries.procTVETProviders.GetprocTVETProvidersByPrimaryKey
{
    /// @author  Shimels Alem proc_TVET_ProvidersLoadByPrimaryKey stored procedure.

    public class GetprocTVETProvidersByPrimaryKey : IRequest<GetprocTVETProvidersLoadAllListVm>
    {
        public string ProviderCode { get; set; }
    }
}
