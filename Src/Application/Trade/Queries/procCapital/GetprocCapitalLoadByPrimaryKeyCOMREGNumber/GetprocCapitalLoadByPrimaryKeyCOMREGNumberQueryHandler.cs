using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Trade.Quiries.procCapital.GetprocCapitalLoadAll;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procCapital.GetprocCapitalLoadByPrimaryKeyCOMREGNumber
{
    public class GetprocCapitalQueryHandler : IRequestHandler<GetprocCapitalLoadByPrimaryKeyCOMREGNumber, GetprocCapitalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCapitalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCapitalLoadAllListVm> Handle(GetprocCapitalLoadByPrimaryKeyCOMREGNumber request, CancellationToken cancellationToken)
        {
           
            IList<Capital> procCapitals = await _procedureAdabter
               .Execute<Capital>("[Trade].[proc_CapitalLoadByPrimaryKey_COM_REG_Number]", request);
            GetprocCapitalLoadAllListVm vm = new GetprocCapitalLoadAllListVm
            {
                procCapitals = _mapper.Map<IList<Capital>, IList<GetprocCapitalLoadAllVm>>(procCapitals)
            };

            return vm;
        }
    }
}
