using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procTemporaryTradeName.GetprocTemporaryTradeNameLoadAll
{
    class GetprocTemporaryTradeNameLoadAllQueryHandler : IRequestHandler<GetprocTemporaryTradeNameLoadAllQuery, GetprocTemporaryTradeNameLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocTemporaryTradeNameLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTemporaryTradeNameLoadAllListVm> Handle(GetprocTemporaryTradeNameLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<TemporaryTradeName> procTemporaryTradeNames = await _procedureAdabter
               .Execute<TemporaryTradeName>("[Trade].[proc_Temporary_Trade_NameLoadAll]");
            GetprocTemporaryTradeNameLoadAllListVm vm = new GetprocTemporaryTradeNameLoadAllListVm
            {
                procTemporaryTradeNames = _mapper.Map<IList<TemporaryTradeName>, IList<GetprocTemporaryTradeNameLoadAllVm>>(procTemporaryTradeNames)
            };

            return vm;
        }
    }
}
