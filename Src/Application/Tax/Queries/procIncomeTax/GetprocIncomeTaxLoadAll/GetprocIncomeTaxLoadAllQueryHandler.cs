using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Quiries.procIncomeTax.GetprocIncomeTaxLoadAll
{
    class GetprocIncomeTaxLoadAllQueryHandler : IRequestHandler<GetprocIncomeTaxLoadAllQuery, GetprocIncomeTaxLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocIncomeTaxLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocIncomeTaxLoadAllListVm> Handle(GetprocIncomeTaxLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<IncomeTax> procIncomeTaxs = await _procedureAdabter
               .Execute<IncomeTax>("[Tax].[proc_Income_TaxLoadAll]");
            GetprocIncomeTaxLoadAllListVm vm = new GetprocIncomeTaxLoadAllListVm
            {
                procIncomeTaxs = _mapper.Map<IList<IncomeTax>, IList<GetprocIncomeTaxLoadAllVm>>(procIncomeTaxs)
            };

            return vm;
        }
    }
}
