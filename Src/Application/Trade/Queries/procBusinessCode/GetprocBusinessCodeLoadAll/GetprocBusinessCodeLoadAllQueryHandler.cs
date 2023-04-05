using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procBusinessCode.GetprocBusinessCodeLoadAll
{
    class GetprocBusinessCodeLoadAllQueryHandler : IRequestHandler<GetprocBusinessCodeLoadAllQuery, GetprocBusinessCodeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocBusinessCodeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBusinessCodeLoadAllListVm> Handle(GetprocBusinessCodeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<BusinessCode> procBusinessCodes = await _procedureAdabter
               .Execute<BusinessCode>("[Trade].[proc_Business_CodeLoadAll]");
            GetprocBusinessCodeLoadAllListVm vm = new GetprocBusinessCodeLoadAllListVm
            {
                procBusinessCodes = _mapper.Map<IList<BusinessCode>, IList<GetprocBusinessCodeLoadAllVm>>(procBusinessCodes)
            };

            return vm;
        }
    }
}
