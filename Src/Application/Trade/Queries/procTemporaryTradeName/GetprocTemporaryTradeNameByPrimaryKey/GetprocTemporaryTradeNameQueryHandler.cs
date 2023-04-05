using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Trade.Quiries.procTemporaryTradeName.GetprocTemporaryTradeNameLoadAll;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procTemporaryTradeName.GetprocTemporaryTradeNameByPrimaryKey
{
    public class GetprocTemporaryTradeNameQueryHandler : IRequestHandler<GetprocTemporaryTradeNameByPrimaryKey, GetprocTemporaryTradeNameLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocTemporaryTradeNameQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTemporaryTradeNameLoadAllListVm> Handle(GetprocTemporaryTradeNameByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<TemporaryTradeName> procTemporaryTradeNames = await _procedureAdabter
               .Execute<TemporaryTradeName>("[Trade].[proc_Temporary_Trade_NameLoadByPrimaryKey]", request);
            GetprocTemporaryTradeNameLoadAllListVm vm = new GetprocTemporaryTradeNameLoadAllListVm
            {
                procTemporaryTradeNames = _mapper.Map<IList<TemporaryTradeName>, IList<GetprocTemporaryTradeNameLoadAllVm>>(procTemporaryTradeNames)
            };

            return vm;
        }
    }
}
