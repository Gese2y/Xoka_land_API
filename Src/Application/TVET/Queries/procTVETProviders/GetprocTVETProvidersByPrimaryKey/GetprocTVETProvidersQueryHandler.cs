using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.TVET.Quiries.procTVETProviders.GetprocTVETProvidersLoadAll;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procTVETProviders.GetprocTVETProvidersByPrimaryKey
{
    public class GetprocTVETProvidersQueryHandler : IRequestHandler<GetprocTVETProvidersByPrimaryKey, GetprocTVETProvidersLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocTVETProvidersQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTVETProvidersLoadAllListVm> Handle(GetprocTVETProvidersByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<TVETProviders> procTVETProviderss = await _procedureAdabter
               .Execute<TVETProviders>("[TVET].[proc_TVET_ProvidersLoadByPrimaryKey]", request);
            GetprocTVETProvidersLoadAllListVm vm = new GetprocTVETProvidersLoadAllListVm
            {
                procTVETProviderss = _mapper.Map<IList<TVETProviders>, IList<GetprocTVETProvidersLoadAllVm>>(procTVETProviderss)
            };

            return vm;
        }
    }
}
