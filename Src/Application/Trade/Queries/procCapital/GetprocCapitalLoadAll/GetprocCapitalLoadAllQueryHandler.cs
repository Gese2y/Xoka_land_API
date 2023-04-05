using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procCapital.GetprocCapitalLoadAll
{
    class GetprocCapitalLoadAllQueryHandler : IRequestHandler<GetprocCapitalLoadAllQuery, GetprocCapitalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCapitalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCapitalLoadAllListVm> Handle(GetprocCapitalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Capital> procCapitals = await _procedureAdabter
               .Execute<Capital>("[Trade].[proc_CapitalLoadAll]");
            GetprocCapitalLoadAllListVm vm = new GetprocCapitalLoadAllListVm
            {
                procCapitals = _mapper.Map<IList<Capital>, IList<GetprocCapitalLoadAllVm>>(procCapitals)
            };

            return vm;
        }
    }
}
